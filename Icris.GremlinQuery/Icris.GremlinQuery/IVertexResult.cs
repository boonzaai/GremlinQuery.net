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
        IVertexResult has(string name, string value);
        IEdgeResult outE(string label=null);
        IEdgeResult inE(string label = null);
    }
}
