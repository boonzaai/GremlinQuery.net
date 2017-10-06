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
        public void ParameterQuery_QueryHasNoPeriods()
        {
            Assert.AreEqual(
                "out()",
                Argument.@out().ToString()
                );
        }
        
        [TestMethod]
        public void ParameterQuery_QueryChainsHavePeriods()
        {
            Assert.AreEqual(
                "out().simplePath()",
                Argument.@out().simplePath().ToString()
                );
        }

        [TestMethod]
        public void ParameterQuery_QueryBuiltProperlyInArgument()
        {
            Assert.AreEqual(
                "g.V('123').repeat(out().simplePath()).until(hasId('5')).path().limit(1)",
                g.V("123").repeat(Argument.@out().simplePath()).until(Argument.hasId("5")).path().limit(1).ToString()
                );
        }
    }
}
