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
        public void Comparers_TestGt()
        {
            Assert.AreEqual("gt(5)", gt(5));
        }
        [TestMethod]
        public void Comparers_TestLt()
        {
            Assert.AreEqual("lt(5)", lt(5));
        }
        [TestMethod]
        public void Comparers_TestEq()
        {
            Assert.AreEqual("eq(5)", eq(5));
        }
        [TestMethod]
        public void Comparers_TestWithin()
        {
            Assert.AreEqual("within('vadas','marko')", within("vadas", "marko"));
        }
    }
}
