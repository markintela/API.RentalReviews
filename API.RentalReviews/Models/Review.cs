using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.RentalReviews.Models
{
    public class Review
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("type_review")]
        public string TypeReview { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("score")]
        public int Score { get; set; }

        [BsonElement("date_review")]
        public DateTime DateReview { get; set; }

        [BsonElement("signatures")]
        public List<Signature> Signature { get; set; }

        public Review()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }
    }
}
