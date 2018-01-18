using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class Query : IEdgeResult, IVertexResult, IGroupResult, IRepeater
    {
        string query = "g";
        /// <summary>
        /// Returns the full Gremlin Query composed from this statement
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return query;
        }
        #region general statements
        /// <summary>
        /// Drop the vertices/edges matching this resultset
        /// </summary>
        /// <returns></returns>
        public Query drop()
        {
            this.query += ".drop()";
            return this;
        }
        /// <summary>
        /// De-duplify this resultset (a.k.a. DISTINCT)
        /// </summary>
        /// <returns></returns>
        public Query dedup()
        {
            this.query += ".dedup()";
            return this;
        }
        /// <summary>
        /// Get the mean value of this resultset (a.k.a. AVERAGE)
        /// </summary>
        /// <returns></returns>
        public IVertexResult mean()
        {
            this.query += ".mean()";
            return this;
        }
        /// <summary>
        /// Add a vertex to the graph. If you want to add more properties to this vertex, add .property() statements after this one.
        /// </summary>
        /// <param name="label">optional label</param>
        /// <returns></returns>
        public Query addV(string label = null)
        {
            if (label == null)
                this.query += ".addV()";
            else
                this.query += $".addV('{label}')";
            return this;
        }
        /// <summary>
        /// Add an edge to the graph. If you want to add more properties to this edge, add .property() statements after this one.
        /// </summary>
        /// <param name="label">optional label</param>
        /// <returns></returns>
        public Query addE(string label = null)
        {
            if (label == null)
                this.query += ".addE()";
            else
                this.query += $".addE('{label}')";
            return this;
        }

        #endregion

        #region interfaces implementation
        public IEdgeResult E(string id = null)
        {
            if (id != null)
                this.query += $".E('{id}')";
            else
                this.query += ".E()";
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

        IVertexResult IVertexResult.hasLabel(string label)
        {
            this.query += $".hasLabel('{label}')";
            return this;
        }

        public IVertexResult until(IArgumentResult condition)
        {
            this.query += $".until({condition})";
            return this;
        }

        public IVertexResult path()
        {
            this.query += ".path()";
            return this;
        }

        public IRepeater repeat(IArgumentResult parameter)
        {
            this.query += $".repeat({parameter})";

            return this;
        }

        public IEdgeResult where(IArgumentResult condition)
        {
            this.query += $".where({condition})";

            return this;
        }

        IVertexResult IVertexResult.limit(int pathLimit)
        {
            this.query += $".limit({pathLimit})";
            return this;
        }

        public IVertexResult times(int count)
        {
            this.query += $".times({count})";
            return this;
        }

        public IVertexResult count(Scope scope = Scope.global)
        {
            if (scope == Scope.global)
                this.query += ".count()";
            else
                this.query += $".count({scope})";
            return this;
        }

        public IEdgeResult bothE(List<string> labels)
        {
            if (labels == null)
                this.query += ".bothE()";
            else
            {
                var labelsString = labels.FirstOrDefault();
                foreach (var label in labels.Skip(1))
                    labelsString += $",{label}";

                this.query += $".bothE({labelsString})";
            }

            return this;
        }


        #endregion


    }
}
