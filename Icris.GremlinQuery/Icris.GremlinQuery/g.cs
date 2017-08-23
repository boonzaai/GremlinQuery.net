using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    /// <summary>
    /// Entry of the graph. Contains methods to query a graph's vertices, edges, or add items to both.
    /// Reminder; if you want to use syntactical comparer support add the following using statement to your class:
    /// using static Icris.GremlinQuery.Comparers;
    /// </summary>
    public static class g
    {
        /// <summary>
        /// Get the graph's vertices. If you specify an id, you'll get the single vertex with this id as a result.
        /// </summary>
        /// <param name="id">String id.</param>
        /// <returns></returns>
        public static IVertexResult V(string id = null)
        {
            return new Query().V(id);
        }
        /// <summary>
        /// Get the graph's vertex with the specified int id.
        /// </summary>
        /// <param name="id">int id.</param>
        /// <returns></returns>
        public static IVertexResult V(int id)
        {
            return new Query().V(id);
        }
        /// <summary>
        /// Get the graph's edges
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IEdgeResult E(string id = null)
        {
            return new Query().E(id);
        }
        /// <summary>
        /// Add a vertex to the graph with a certain label. Extend the expression with a number of property() statements.
        /// </summary>
        /// <param name="label">Label of the newly added vertex. (i.e. "person")</param>
        /// <returns></returns>
        public static IVertexResult addV(string label = null)
        {
            return new Query().addV(label);
        }
        /// <summary>
        /// Add an edge to the graph with a certain label. Extend the expression with a number of property() statements.
        /// </summary>
        /// <param name="label">Label of the newly added ege. (i.e. "owns")</param>
        /// <returns></returns>
        public static IEdgeResult addE(string label = null)
        {
            return new Query().addE(label);
        }
    }
}
