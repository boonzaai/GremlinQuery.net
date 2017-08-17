using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public static class Comparers
    {
        public static string gt(string value)
        {
            return $"gt({value})";
        }
        public static string lt(string value)
        {
            return $"lt({value})";
        }
        public static string eq(string value)
        {
            return $"eq({value})";
        }
    }
    
}
