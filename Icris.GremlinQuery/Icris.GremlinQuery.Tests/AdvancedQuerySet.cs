using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Icris.GremlinQuery.Tests
{
    [TestClass]
    public class AdvancedQuerySet
    {
        [TestMethod]
        public void AdvancedQueryTestAddEdge()
        {
            Assert.AreEqual("g.V('andre.boonzaaijer@icris.nl').addE('knows').to(g.V('bill.gates@microsoft.com'))",
                            g.V("andre.boonzaaijer@icris.nl").addE("knows").to(g.V("bill.gates@microsoft.com")).ToString());
        }

        [TestMethod]
        public void AdvancedQueryTestTypeCountByLabel()
        {
            Assert.AreEqual("g.V('andre.boonzaaijer@icris.nl').inE().has('label','owner').outV().out().has('label','car').dedup().count()",
                            g.V("andre.boonzaaijer@icris.nl").inE().has("label","owner").outV().@out().has("label","car").dedup().count().ToString());

        }
    }
}
