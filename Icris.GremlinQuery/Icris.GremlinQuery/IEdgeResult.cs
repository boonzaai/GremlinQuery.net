using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    /// <summary>
    /// Represents a resultset of edges.
    /// </summary>
    public interface IEdgeResult
    {
        /// <summary>
        /// Get the graph's edges
        /// </summary>
        IEdgeResult E(string id = null);
        /// <summary>
        /// Adds the given property and value to the vertex/edge
        /// </summary>
        IEdgeResult property(string name, string value);
        /// <summary>
        /// Indicates where to step to in the graph
        /// </summary>
        IEdgeResult to(IVertexResult goal);
        /// <summary>
        /// Indicates where to step from in the graph
        /// </summary>
        IEdgeResult from(IVertexResult source);
        /// <summary>
        /// Remove the traverser if its element does not have the label
        /// </summary>
        IEdgeResult hasLabel(string label);
        /// <summary>
        /// Remove the traverser if its element does not have the id
        /// </summary>
        IEdgeResult hasId(string label);
        /// <summary>
        /// Remove the traverser if its element does not have a key value that satisfies the bi-predicate
        /// </summary>
        IEdgeResult has(string name, string comparerOrValue);
        /// <summary>
        /// Move to the incoming vertex
        /// </summary>
        IVertexResult inV(string label=null);
        /// <summary>
        /// Move to the outgoing vertex
        /// </summary>
        IVertexResult outV(string label=null);
        /// <summary>
        /// limits the number of outputs to the given number
        /// </summary>
        IEdgeResult limit(int limit);
        /// <summary>
        /// filters the traversal based on the given condition
        /// </summary>
        IEdgeResult where(IArgumentResult condition);
        /// <summary>
        /// Removed the current edge from the graph
        /// </summary>
        Query drop();
    }
}
