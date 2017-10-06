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
    public interface IParameterResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IParameterResult hasId(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IParameterResult hasId(int id);
        IParameterResult hasLabel(string label);
        IParameterResult otherV();
        IParameterResult @out();
        ParameterQuery simplePath();
    }
}
