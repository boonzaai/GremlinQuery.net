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
            var expected = "g.addV('person').property('name','marko').property('age',29).property('id',1)";
            var actual = g.addV("person").property("name", "marko").property("age", 29).property("id", 1).ToString();
            Assert.AreEqual(expected, actual);

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
                g.V(1).@out("knows").values("name").ToString()
                );

            Assert.AreEqual(
                "g.V(1).out('knows').has('age',gt(30)).values('name')",
                g.V(1).@out("knows").has("age", gt(30)).values("name").ToString()
                );
            //Status that is true or false
            Assert.AreEqual(
                "g.V().has('status',true)",
                g.V().has("status", true).ToString()
            );
            Assert.AreEqual(
                "g.V().has('status',false)",
                g.V().has("status", false).ToString()
            );
            //Test Integer
            Assert.AreEqual(
                "g.V().has('status',1)",
                g.V().has("status", (int)1).ToString()
            );
            //Test Double
            Assert.AreEqual(
                "g.V().has('status',1.5223)",
                g.V().has("status", (double)1.5223).ToString()
            );
            //test boolean property
            Assert.AreEqual(
                "g.V().property('status',true)",
                g.V().property("status", true).ToString()
            );
            Assert.AreEqual(
                "g.V().property('status',false)",
                g.V().property("status", false).ToString()
            );
            //Test interger property
            Assert.AreEqual(
                "g.V().property('status',1)",
                g.V().property("status", 1).ToString()
            );
            Assert.AreEqual(
                "g.V().property('status',1)",
                g.V().property("status", 1).ToString()
            );
        }

        [TestMethod]
        public void Queries_GremlinTinkerPopWorkout_NextFifteenMinutes()
        {
            //Find vertices with name = marko
            Assert.AreEqual(
                "g.V().has('name','marko')",
                g.V().has("name", "marko").ToString()
                );
            Assert.AreEqual(
                "g.V().has('name','marko').outE('created')",
                g.V().has("name", "marko").outE("created").ToString()
                );
            Assert.AreEqual(
                "g.V().has('name','marko').outE('created').inV()",
                g.V().has("name","marko").outE("created").inV().ToString()
                );
            Assert.AreEqual(
                "g.V().has('name','marko').out('created')",
                g.V().has("name", "marko").@out("created").ToString()
                );
            Assert.AreEqual(
                "g.V().has('name','marko').out('created').values('name')",
                g.V().has("name","marko").@out("created").values("name").ToString()
                );
            Assert.AreEqual(
                "g.V().has('name',within('vadas','marko')).values('age').mean()",
                g.V().has("name", within("vadas","marko")).values("age").mean().ToString()
                );
            Assert.AreEqual(
                "g.V().has('name','marko').out('created')",
                g.V().has("name", "marko").@out("created").ToString()
                );
            Assert.AreEqual(
                "g.V().has('name','marko').out('created').in('created').values('name')",
                g.V().has("name", "marko").@out("created").@in("created").values("name").ToString()
                );
            Assert.AreEqual(
                "g.V().as('a').out().as('b').out().as('c').select('a','b','c')",
                g.V().@as("a").@out().@as("b").@out().@as("c").select("a","b","c").ToString()
                );
            Assert.AreEqual(
                "g.V().group().by(label).by('name')",
                g.V().group().by(property.label).by("name").ToString()
                );


        }
    }
}
