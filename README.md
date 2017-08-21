# GremlinQuery.net
A strong-typed gremlin query generator class, compatible with Azure CosmosDB capabilities. It is a DSL (Domain Specific Language) for supporting Gremlin Queries embedded in your C# code.

It allows you to generate a Gremlin Query like this:

```C#
g.V().has("name","marko").outE("created").inV().ToString()
```
