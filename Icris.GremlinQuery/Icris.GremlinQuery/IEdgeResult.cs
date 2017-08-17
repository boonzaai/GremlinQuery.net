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
    interface IEdgeResult
    {
        IEdgeResult E();
        IEdgeResult property(string name, string value);
        IEdgeResult to(IVertexResult goal);
        IEdgeResult from(IVertexResult source);
        IEdgeResult hasLabel(string label);
        IEdgeResult hasId(string label);
        IEdgeResult has(string name, string value);
        IVertexResult inV();
        IVertexResult outV();
        void count();
        IEdgeResult dedup();
        void drop();
        IEdgeResult limit(int limit);
    }
}
