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
    interface IVertexResult
    {
        IVertexResult V();
        IVertexResult has(string name, string value);

    }
}
