using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class Query
    {
        string query = "g";
        public Query has(string property, string value)
        {
            this.query += $".has('{property}','{value}')";
            return this;
        }
        public void count()
        {
            this.query += ".count()";
        }

        public Query addV(string label)
        {
            this.query += ".addV('')";
            return this;
        }

        public Query V()
        {
            this.query += ".V()";
            return this;
        }
        public Query E()
        {
            this.query += ".E()";
            return this;
        }

        public override string ToString()
        {
            return query;
        }
    }
}
