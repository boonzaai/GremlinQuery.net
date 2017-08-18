using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public static class g
    {
        public static IVertexResult V(string id = null)
        {
            return new Query().V(id);
        }
        public static IVertexResult V(int id)
        {
            return new Query().V(id);
        }
        public static IEdgeResult E(string id = null)
        {
            return new Query().E(id);
        }
        public static IVertexResult addV(string label = null)
        {
            return new Query().addV(label);
        }
        public static IEdgeResult addE(string label = null)
        {
            return new Query().addE(label);
        }
    }
}
