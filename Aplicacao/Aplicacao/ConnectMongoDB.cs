using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Aplicacao
{ 

    public class ConnectMongoDB
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string NomeUser { get; set; }
    public string Lugtot { get; set; }

}
}