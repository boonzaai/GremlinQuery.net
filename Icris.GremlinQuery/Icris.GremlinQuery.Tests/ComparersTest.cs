using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Icris.GremlinQuery.Comparers;

namespace Icris.GremlinQuery.Tests
{
    [TestClass]
    public class ComparersTest
    {
        [TestMethod]
        public void TestGt()
        {
            Assert.AreEqual("gt(5)", gt("5"));
        }
    }
}
