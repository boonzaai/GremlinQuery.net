using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    /// <summary>
    /// Represents a resultset of vertices.
    /// </summary>
    public interface IVertexResult
    {
        /// <summary>
        /// Get the graph's vertices. If you specify an id, you'll get the single vertex with this id as a result.
        /// </summary>
        IVertexResult V(string id = null);
        /// <summary>
        /// Get the graph's vertex with the specified int id.
        /// </summary>
        IVertexResult V(int id);
        /// <summary>
        /// Removes traverser if element does not have given property with value
        /// </summary>
        IVertexResult has(string name, string value);
        /// <summary>
        /// Removes traverser if element does not have given property with value
        /// </summary>
        IVertexResult has(string name, bool value);
        /// <summary>
        /// Removes traverser if element does not satisfy the given comparison
        /// </summary>
        IVertexResult has(string name, Comparer comparer);
        /// <summary>
        /// Remove the traverser if its element does not have the label
        /// </summary>
        IVertexResult hasLabel(string label);
        /// <summary>
        /// Move to the outgoing edge
        /// </summary>
        IEdgeResult outE(string label = null);
        /// <summary>
        /// Move to the incoming edge
        /// </summary>
        IEdgeResult inE(string label = null);
        /// <summary>
        /// Move to both the incoming and outgoing incident edges given the edge labels
        /// </summary>
        IEdgeResult bothE(List<string> labels = null);
        /// <summary>
        /// Adds property with value to the vertex
        /// </summary>
        IVertexResult property(string name, string value);
        /// <summary>
        /// Adds property with value to the vertex
        /// </summary>
        IVertexResult property(string name, int value);
        /// <summary>
        /// Adds property with value to the vertex
        /// </summary>
        IVertexResult property(string name, double value);
        /// <summary>
        /// Adds property with value to the vertex
        /// </summary>
        IVertexResult property(string name, bool value);
        /// <summary>
        /// Extracts the values of properties from an Element in the traversal stream
        /// </summary>
        IVertexResult values(params string[] fields);
        /// <summary>
        /// Selects the specified objects out of the current map
        /// </summary>
        IVertexResult select(params string[] names);
        /// <summary>
        /// Performs an out going traversal step
        /// </summary>
        IVertexResult @out(string label = null);
        /// <summary>
        /// Performs an in going traversal step
        /// </summary>
        IVertexResult @in(string label = null);
        /// <summary>
        /// With as(), it is possible to provide a label to the step that can later be accessed by steps
        /// and data structures that make use of such labels — e.g., select(), match(), and path
        /// </summary>
        IVertexResult @as(string name);
        /// <summary>
        /// Groups the values based on the labels specified
        /// </summary>
        IGroupResult group();
        IVertexResult by(string label);
        /// <summary>
        /// Operates on a stream of numbers and determines the average of those numbers
        /// </summary>
        IVertexResult mean();
        /// <summary>
        /// Returns the history of the traversed path
        /// </summary>
        IVertexResult path();
        /// <summary>
        /// Limits the returned paths
        /// </summary>
        /// <param name="pathLimit">Maximum number of paths to return</param>
        IVertexResult limit(int pathLimit);
        /// <summary>
        /// Used for looping over a traversal given some break predicate
        /// </summary>
        IRepeater repeat(IArgumentResult parameter);
        /// <summary>
        /// Adds edge to graph
        /// </summary>
        Query addE(string label = null);
        /// <summary>
        /// Removes vertex from graph
        /// </summary>
        Query drop();
        /// <summary>
        /// Returns the values with the duplicates removed
        /// </summary>
        Query dedup();
        /// <summary>
        /// Returns the count from the traversal
        /// </summary>
        IVertexResult count(Scope scope = Scope.global);

    }

    public enum property
    {
        label,
        id
    }

    public enum Scope
    {
        global,
        local
    }

    public interface IGroupResult
    {
        /// <summary>
        /// groups elements by specified field
        /// </summary>
        IGroupResult by(property field);
        /// <summary>
        /// groups elements by specified field
        /// </summary>
        IGroupResult by(string field);
    }
}
