using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Icris.GremlinQuery.Tests
{
    /// <summary>
    /// Summary description for ParameterQueryTests
    /// </summary>
    [TestClass]
    public class ParameterQueryTests
    {
        [TestMethod]
        public void ParameterQuery_QueryHasNoPeriods()
        {
            Assert.AreEqual(
                "out()",
                Parameter.@out().ToString()
                );
        }
        
        [TestMethod]
        public void ParameterQuery_QueryChainsHavePeriods()
        {
            Assert.AreEqual(
                "out().simplePath()",
                Parameter.@out().simplePath().ToString()
                );
        }

        [TestMethod]
        public void ParameterQuery_QueryBuiltProperlyInArgument()
        {
            Assert.AreEqual(
                "g.V('123').repeat(out().simplePath()).until(hasId('5')).path().limit(1)",
                g.V("123").repeat(Parameter.@out().simplePath()).until(Parameter.hasId("5")).path().limit(1).ToString()
                );
        }
    }
}
