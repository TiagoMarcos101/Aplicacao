using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace Aplicacao
{ 

    public partial class ConnectMongoDB
{
     


  public static IMongoClient client { get; set; }
  public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb://Jacare:vermelho2004@cluster0-shard-00-00.flr0m.mongodb.net:27017,cluster0-shard-00-01.flr0m.mongodb.net:27017,cluster0-shard-00-02.flr0m.mongodb.net:27017/project?ssl=true&replicaSet=atlas-13durq-shard-0&authSource=admin&retryWrites=true&w=majority";
        public static string MongoDatabase = "project";

        public void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Getdblist(var MongoConnetion)
        {

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }





}
}