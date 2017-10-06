using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public static class Parameter
    {
        public static IParameterResult hasId(string id)
        {
            return new ParameterQuery().hasId(id);
        }

        public static IParameterResult hasId(int id)
        {
            return new ParameterQuery().hasId(id);
        }

        public static IParameterResult hasLabel(string label)
        {
            return new ParameterQuery().hasLabel(label);
        }

        public static IParameterResult otherV()
        {
            return new ParameterQuery().otherV();
        }

        public static IParameterResult @out()
        {
            return new ParameterQuery().@out();
        }
    }
}
