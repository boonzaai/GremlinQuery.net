using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class ArgumentQuery : IArgumentResult
    {
        string query = "";

        public override string ToString()
        {
            return query.TrimStart('.');
        }

        public IArgumentResult hasId(string id)
        {
            query += $".hasId('{id}')";

            return this;
        }

        public IArgumentResult hasId(int id)
        {
            query += $".hasId({id})";

            return this;
        }

        public IArgumentResult hasLabel(string label)
        {
            query += $".hasLabel('{label}')";

            return this;
        }

        public IArgumentResult otherV()
        {
            query += ".otherV()";

            return this;
        }

        public IArgumentResult @out()
        {
            query += ".out()";

            return this;
        }

        /// <summary>
        /// must be last in chain
        /// </summary>
        /// <returns></returns>
        public ArgumentQuery simplePath()
        {
            this.query += ".simplePath()";

            return this;
        }
    }
}
