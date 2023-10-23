using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.RenalReviews.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string Nome { get; set; }

        [BsonElement("From")]
        public string? From { get; set; }


    }
}