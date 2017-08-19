using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery
{
    public class Comparer
    {
        string comparer = "";
        public Comparer(string comparer)
        {
            this.comparer = comparer;
        }
        public static implicit operator string(Comparer d)
        {
            return d.ToString();
        }
        public override string ToString()
        {
            return this.comparer;
        }
    }
    public static class Comparers
    {
        public static Comparer gt(string value)
        {
            return new Comparer($"gt('{value}')");
        }
        public static Comparer lt(string value)
        {
            return new Comparer($"lt('{value}')");
        }
        public static Comparer eq(string value)
        {
            return new Comparer($"eq('{value}')");
        }
        public static Comparer gt(int value)
        {
            return new GremlinQuery.Comparer($"gt({value})");
        }
        public static Comparer lt(int value)
        {
            return new Comparer($"lt({value})");
        }
        public static Comparer eq(int value)
        {
            return new Comparer($"eq({value})");
        }
        public static Comparer within(params string[] values)
        {
            return new Comparer($"within({values.Select(x => $"'{x}'").Aggregate((a, b) => a + "," + b) })");
        }
    }

}
