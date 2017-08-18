using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class Query:IEdgeResult,IVertexResult
    {
        string query = "g";
        
        public override string ToString()
        {
            return query;
        }

        public IVertexResult V(int id)
        {
            throw new NotImplementedException();
        }
        public IVertexResult V(string id = null)
        {
            throw new NotImplementedException();
        }

        IVertexResult IVertexResult.has(string name, string value)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult outE(string label = null)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult inE(string label = null)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult E(string id = null)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult property(string name, string value)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult to(IVertexResult goal)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult from(IVertexResult source)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult hasLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult hasId(string label)
        {
            throw new NotImplementedException();
        }

        IEdgeResult IEdgeResult.has(string name, string value)
        {
            throw new NotImplementedException();
        }

        

        public IVertexResult outV(string label = null)
        {
            throw new NotImplementedException();
        }

        public IEdgeResult dedup()
        {
            throw new NotImplementedException();
        }

        public void drop()
        {
            throw new NotImplementedException();
        }

        public void values()
        {
            throw new NotImplementedException();
        }

        public IEdgeResult limit(int limit)
        {
            throw new NotImplementedException();
        }

        public IVertexResult inV(string label = null)
        {
            throw new NotImplementedException();
        }

        public void count()
        {
            throw new NotImplementedException();
        }
        public IEdgeResult addE(string label=null)
        {
            throw new NotImplementedException();
        }
        public IVertexResult addV(string label = null)
        {
            throw new NotImplementedException();
        }       

        IVertexResult IVertexResult.property(string name, string value)
        {
            throw new NotImplementedException();
        }

        public IVertexResult property(string name, int value)
        {
            throw new NotImplementedException();
        }

        public IVertexResult property(string name, double value)
        {
            throw new NotImplementedException();
        }

        public IVertexResult values(params string[] fields)
        {
            throw new NotImplementedException();
        }

        public IVertexResult @out(string label = null)
        {
            throw new NotImplementedException();
        }
    }
}
