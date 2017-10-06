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
        IEdgeResult E(string id = null);
        IEdgeResult property(string name, string value);
        IEdgeResult to(IVertexResult goal);
        IEdgeResult from(IVertexResult source);
        IEdgeResult hasLabel(string label);
        IEdgeResult hasId(string label);
        IEdgeResult has(string name, string comparerOrValue);
        IVertexResult inV(string label=null);
        IVertexResult outV(string label=null);        
        IEdgeResult limit(int limit);
        IVertexResult where(IParameterResult parameter);
    }
}
