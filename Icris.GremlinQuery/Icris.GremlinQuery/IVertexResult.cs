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
        
        IVertexResult V(string id=null);
        IVertexResult V(int id);
        IVertexResult has(string name, string value);
        IEdgeResult outE(string label=null);
        IEdgeResult inE(string label = null);
        IVertexResult property(string name, string value);
        IVertexResult property(string name, int value);
        IVertexResult property(string name, double value);
        IVertexResult values(params string[] fields);
        IVertexResult @out(string label = null);
    }
}
