using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EntityData.Models
{
    public class Signature
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public int SignedById { get; set; }
        public string SignedByName { get; set; }
        public DateTime DateSignature { get; set; }
        public string Comment { get; set; }

    }
}
