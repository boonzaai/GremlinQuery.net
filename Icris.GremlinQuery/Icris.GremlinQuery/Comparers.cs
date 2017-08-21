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
        /// <summary>
        /// Greater-than comparer (>)
        /// </summary>
        /// <param name="value">String value to compare with</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer gt(string value)
        {
            return new Comparer($"gt('{value}')");
        }
        /// <summary>
        /// Less-than comparer (<)
        /// </summary>
        /// <param name="value">String value to compare with</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer lt(string value)
        {
            return new Comparer($"lt('{value}')");
        }
        /// <summary>
        /// Equals comparer (=)
        /// </summary>
        /// <param name="value">String value to compare with</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer eq(string value)
        {
            return new Comparer($"eq('{value}')");
        }
        /// <summary>
        /// Greater-than comparer (>)
        /// </summary>
        /// <param name="value">Integer value to compare with</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer gt(int value)
        {
            return new GremlinQuery.Comparer($"gt({value})");
        }
        /// <summary>
        /// Less-than comparer (<)
        /// </summary>
        /// <param name="value">Integer value to compare with</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer lt(int value)
        {
            return new Comparer($"lt({value})");
        }
        /// <summary>
        /// Equality comparer (=)
        /// </summary>
        /// <param name="value">Integer value to compare with</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer eq(int value)
        {
            return new Comparer($"eq({value})");
        }
        /// <summary>
        /// Within comparer
        /// </summary>
        /// <param name="values">A list of string values to search</param>
        /// <returns>Comparer (implicitly converted to string)</returns>
        public static Comparer within(params string[] values)
        {
            return new Comparer($"within({values.Select(x => $"'{x}'").Aggregate((a, b) => a + "," + b) })");
        }
    }

}
