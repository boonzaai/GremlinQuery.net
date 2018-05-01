using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Icris.GremlinQuery.Tests
{
    [TestClass]
    public class ArgumentQueryTests
    {
        [TestMethod]
        public void ArgumentQuery_QueryHasNoPeriods()
        {
            Assert.AreEqual(
                "out()",
                Argument.@out().ToString()
                );
        }
        
        [TestMethod]
        public void ArgumentQuery_QueryChainsHavePeriods()
        {
            Assert.AreEqual(
                "out().simplePath()",
                Argument.@out().simplePath().ToString()
                );
        }

        [TestMethod]
        public void ArgumentQuery_QueryBuiltProperlyInArgument()
        {
            Assert.AreEqual(
                "g.V('123').repeat(out().simplePath()).until(hasId('5')).path().limit(1)",
                g.V("123").repeat(Argument.@out().simplePath()).until(Argument.hasId("5")).path().limit(1).ToString()
                );
        }
        [TestMethod]
        public void ArgumentQuery_OtherVTest()
        {
            Assert.AreEqual("g.V('abc').outE('isType').where(otherV().hasId('def'))",
            g.V("abc").outE("isType").where(Argument.otherV().hasId("def")).ToString()
            );
        }
        [TestMethod]
        public void ArgumentQuery_OtherV2Test()
        {
            Assert.AreEqual("g.V('abc').outE('isType').where(otherV().has('id','def'))",
            g.V("abc").outE("isType").where(Argument.otherV().has("id","def")).ToString()
            );
        }
    }
}
