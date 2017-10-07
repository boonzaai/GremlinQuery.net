using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    /// <summary>
    /// Query results used as parameters in other queries
    /// </summary>
    public interface IArgumentResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IArgumentResult hasId(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IArgumentResult hasId(int id);
        /// <summary>
        /// Remove the traverser if its element does not have the label
        /// </summary>
        IArgumentResult hasLabel(string label);
        /// <summary>
        /// Move to the vertex that was not the vertex that was moved from
        /// </summary>
        IArgumentResult otherV();
        /// <summary>
        /// Performs an out going traversal step
        /// </summary>
        IArgumentResult @out();
        /// <summary>
        /// Returns the history of the traversed path without repeating traversals
        /// </summary>
        ArgumentQuery simplePath();
    }
}
