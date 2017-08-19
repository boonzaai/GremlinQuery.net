using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class Query : IEdgeResult, IVertexResult, IGroupResult
    {
        string query = "g";

        public override string ToString()
        {
            return query;
        }
        #region general statements
        public Query drop()
        {
            this.query += ".drop()";
            return this;
        }
        public Query dedup()
        {
            this.query += ".dedup()";
            return this;
        }
        public Query count()
        {
            this.query += ".count()";
            return this;
        }
        public IVertexResult mean()
        {
            this.query += ".mean()";
            return this;
        }
        public Query addV()
        {
            this.query += ".addV()";
            return this;
        }
        public Query addE()
        {
            this.query += ".addE()";
            return this;
        }
        public Query addV(string label)
        {
            this.query += $".addV('{label}')";
            return this;
        }
        public Query addE(string label)
        {
            this.query += $".addE('{label}')";
            return this;
        }

        #endregion

        #region interfaces implementation
        public IEdgeResult E(string id = null)
        {
            if (id != null)
                this.query += $"E('{id}')";
            else
                this.query += "E()";
            return this;
        }

        public IEdgeResult property(string name, string value)
        {
            this.query += $".property('{name}','{value}')";
            return this;
        }

        public IEdgeResult to(IVertexResult goal)
        {
            this.query += $".to({goal.ToString()})";
            return this;
        }

        public IEdgeResult from(IVertexResult source)
        {
            this.query += $".from({source.ToString()})";
            return this;
        }

        public IEdgeResult hasLabel(string label)
        {
            this.query += $".hasLabel('{label}')";
            return this;
        }

        public IEdgeResult hasId(string label)
        {
            this.query += $".hasId('{label}')";
            return this;
        }

        public IEdgeResult has(string name, string comparerOrValue)
        {
            this.query += $".has('{name}','{comparerOrValue}')";
            return this;
        }


        public IVertexResult inV(string label = null)
        {
            if (label != null)
                this.query += $".inV('{label}')";
            else
                this.query += ".inV()";
            return this;
        }

        public IVertexResult outV(string label = null)
        {
            if (label != null)
                this.query += $".outV('{label}')";
            else
                this.query += ".outV()";
            return this;
        }

        public IEdgeResult limit(int limit)
        {
            this.query += $".limit({limit})";
            return this;
        }

        public IVertexResult V(string id = null)
        {
            if (id != null)
                this.query += $".V('{id}')";
            else
                this.query += ".V()";
            return this;
        }

        public IVertexResult V(int id)
        {
            this.query += $".V({id})";
            return this;
        }

        IVertexResult IVertexResult.has(string name, string value)
        {
            this.query += $".has('{name}','{value}')";
            return this;
        }
        public IVertexResult has(string name, Comparer comparer)
        {
            this.query += $".has('{name}',{comparer})";
            return this;
        }

        public IEdgeResult outE(string label = null)
        {
            if (label != null)
                this.query += $".outE('{label}')";
            else
                this.query += ".outE()";
            return this;

        }

        public IEdgeResult inE(string label = null)
        {
            if (label != null)
                this.query += $".inE('{label}')";
            else
                this.query += ".inE()";
            return this;
        }

        IVertexResult IVertexResult.property(string name, string value)
        {
            this.query += $".property('{name}','{value}')";
            return this;
        }

        public IVertexResult property(string name, int value)
        {
            this.query += $".property('{name}',{value})";
            return this;
        }

        public IVertexResult property(string name, double value)
        {
            this.query += $".property('{name}',{value.ToString(CultureInfo.InvariantCulture)})";
            return this;
        }

        public IVertexResult values(params string[] fields)
        {
            this.query += $".values({fields.Select(x => $"'{x}'").Aggregate((a, b) => a + "," + b) })";
            return this;
        }

        public IVertexResult select(params string[] names)
        {
            this.query += $".select({names.Select(x => $"'{x}'").Aggregate((a, b) => a + "," + b) })";
            return this;
        }

        public IVertexResult @out(string label = null)
        {
            if (label != null)
                this.query += $".out('{label}')";
            else
                this.query += ".out()";
            return this;
        }

        public IVertexResult @in(string label = null)
        {
            if (label != null)
                this.query += $".in('{label}')";
            else
                this.query += ".in()";
            return this;
        }

        public IVertexResult @as(string name)
        {
            this.query += $".as('{name}')";
            return this;
        }

        public IGroupResult group()
        {
            this.query += ".group()";
            return this;
        }

        public IVertexResult by(string label)
        {
            this.query += $".by('{label}')";
            return this;    
        }

        public IGroupResult by(property field)
        {
            this.query += $".by({field})";
            return this;
        }

        IGroupResult IGroupResult.by(string field)
        {
            this.query += $".by('{field}')";
            return this;
        }

        
        #endregion


    }
}
