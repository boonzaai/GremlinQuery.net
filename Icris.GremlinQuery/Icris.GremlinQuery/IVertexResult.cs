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

        IVertexResult V(string id = null);
        IVertexResult V(int id);
        IVertexResult has(string name, string value);
        IVertexResult has(string name, Comparer comparer);
        IVertexResult hasLabel(string label);
        IEdgeResult outE(string label = null);
        IEdgeResult inE(string label = null);
        IEdgeResult bothE(List<string> labels = null);
        IVertexResult property(string name, string value);
        IVertexResult property(string name, int value);
        IVertexResult property(string name, double value);
        IVertexResult values(params string[] fields);
        IVertexResult select(params string[] names);
        IVertexResult @out(string label = null);
        IVertexResult @in(string label = null);
        IVertexResult @as(string name);
        IGroupResult group();
        IVertexResult by(string label);
        IVertexResult mean();
        IVertexResult path();
        /// <summary>
        /// Limits the returned paths
        /// </summary>
        /// <param name="pathLimit">Maximum number of paths to return</param>
        /// <returns></returns>
        IVertexResult limit(int pathLimit);
        IRepeater repeat(IParameterResult parameter);
        Query addE(string label = null);
        Query drop();
        Query dedup();
        IVertexResult count();

    }
    public enum property
    {
        label,
        id
    }
    public interface IGroupResult
    {
        IGroupResult by(property field);
        IGroupResult by(string field);
    }
}
