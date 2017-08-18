using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Icris.GremlinQuery.Comparers;

namespace Icris.GremlinQuery.Tests
{
    [TestClass]
    public class QueryTestSet
    {
        [TestMethod]
        public void Queries_GremlinTinkerPopWorkout_FirstFiveMinutes()
        {
            //Node addition. Pre-condition to running all statements below (which we won't do here but nonetheless, it doesn't seem right not to do test this in the first place).
            Assert.AreEqual(
                "g.addV('person').property('name','marko').property('age',29).property('id',1)",
                g.addV("person").property("name", "marko").property("age", 29).property("id", 8).ToString()
            );

            //All vertices
            Assert.AreEqual(
                "g.V()",
                g.V().ToString()
                );
            //single vertex
            Assert.AreEqual(
                "g.V(1)",
                g.V(1).ToString()
                );
            //get vertex 1's name property.
            Assert.AreEqual(
                "g.V(1).values('name')",
                g.V(1).values("name").ToString()
                );
            //get edges with label 'knows' for vertex 1
            Assert.AreEqual(
                "g.V(1).outE('knows')",
                g.V(1).outE("knows").ToString()
                );
            //Names of the people 1 knows
            Assert.AreEqual(
                "g.V(1).outE('knows').inV().values('name')",
                g.V(1).outE("knows").inV().values("name").ToString()
                );

            Assert.AreEqual(
                "g.V(1).out('knows').values('name')",
                g.V(1).@out("knows").values("name")
                );

            Assert.AreEqual(
                "g.V(1).out('knows').has('age',gt(30)).values('name')",
                g.V(1).@out("knows").has("age", gt(30)).values("name")
                );

        }
    }
}
