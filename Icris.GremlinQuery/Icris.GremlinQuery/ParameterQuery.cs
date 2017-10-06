using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class ParameterQuery : IParameterResult
    {
        string query = "";

        public override string ToString()
        {
            return query.TrimStart('.');
        }

        public IParameterResult hasId(string id)
        {
            query += $".hasId('{id}')";

            return this;
        }

        public IParameterResult hasId(int id)
        {
            query += $".hasId({id})";

            return this;
        }

        public IParameterResult hasLabel(string label)
        {
            query += $".hasLabel('{label}')";

            return this;
        }

        public IParameterResult otherV()
        {
            query += ".otherV()";

            return this;
        }

        public IParameterResult @out()
        {
            query += ".out()";

            return this;
        }

        /// <summary>
        /// must be last in chain
        /// </summary>
        /// <returns></returns>
        public ParameterQuery simplePath()
        {
            this.query += ".simplePath()";

            return this;
        }
    }
}
