using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    /// <summary>
    /// Used for moving through multiple vertecies and edges
    /// </summary>
    public interface IRepeater
    {
        /// <summary>
        /// Will continue moving through vertecies and edges until condition is met
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        IVertexResult until(IArgumentResult condition);
        /// <summary>
        /// Will move through verticies and edges the supplied number of times
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        IVertexResult times(int count);
    }
}
