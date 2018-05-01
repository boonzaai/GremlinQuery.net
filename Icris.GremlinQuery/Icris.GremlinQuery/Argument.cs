using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public static class Argument
    {
        public static IArgumentResult hasId(string id)
        {
            return new ArgumentQuery().hasId(id);
        }

        public static IArgumentResult hasId(int id)
        {
            return new ArgumentQuery().hasId(id);
        }
        public static IArgumentResult has(string property, int value)
        {
            return new ArgumentQuery().has(property, value);
        }
        public static IArgumentResult has(string property, string value)
        {
            return new ArgumentQuery().has(property, value);
        }

        public static IArgumentResult hasLabel(string label)
        {
            return new ArgumentQuery().hasLabel(label);
        }

        public static IArgumentResult otherV()
        {
            return new ArgumentQuery().otherV();
        }

        public static IArgumentResult @out()
        {
            return new ArgumentQuery().@out();
        }
    }
}
