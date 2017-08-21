using Icris.GremlinQuery;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Microsoft.Azure.Graphs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icris.GremlinQuery.ConsoleApp
{
    class Program
    {
        static string serviceEndpoint = "[Your service endpoint url]";
        static string authKey = "[Your auth key]";
        static string databaseId = "[database id]";
        static string documentCollection = "[document collection id]";

        static void Main(string[] args)
        {
            //Queries all the nodes in the database with label 'user'.
            Console.WriteLine(Query(new Query().V().has("label", "user").ToString()).GetAwaiter().GetResult().ToString());
            Console.ReadLine();
        }

        static async Task<JArray> Query(string query)
        {
            var result = new JArray();
            using (var client = new DocumentClient(new Uri(serviceEndpoint),authKey,                 
                new ConnectionPolicy { ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Https }))
            {
                try
                {
                    //Database database = await client.CreateDatabaseIfNotExistsAsync(new Database { Id = "graphdb" });

                    DocumentCollection graph = await client.CreateDocumentCollectionIfNotExistsAsync(
                        UriFactory.CreateDatabaseUri(databaseId),
                        new DocumentCollection { Id = documentCollection });
                    try
                    {
                        // The CreateGremlinQuery method extensions allow you to execute Gremlin queries and iterate
                        // results asychronously
                        IDocumentQuery<dynamic> q = client.CreateGremlinQuery<dynamic>(graph, query);
                        while (q.HasMoreResults)
                        {
                            foreach (dynamic qresult in await q.ExecuteNextAsync())
                            {
                                if (qresult.GetType().IsPrimitive)
                                    result.Add(JObject.FromObject(new { value = qresult }));
                                else
                                    result.Add(JObject.FromObject(qresult));// log.AppendLine($"\t {JsonConvert.SerializeObject(qresult)}");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        if (!e.Message.Contains("exists"))
                            result.Add(JObject.FromObject(new { Error = e.Message, Query = query }));
                    }

                }
                catch (Exception p)
                {
                    if (!p.Message.Contains("exists"))
                        result.Add(JObject.FromObject(new { Error = p.Message, Query = query }));
                }
                return result;
            }
        }
    }
}
