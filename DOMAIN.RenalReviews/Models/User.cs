using MongoDB.Bson.Serialization.Attributes;

namespace DOMAIN.RenalReviews.Models
{
    public class User
    {
        [BsonId]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string Nome { get; set; }

        [BsonElement("From")]
        public string? From { get; set; }

        [BsonElement("Rents")]
        public List<Rent> Rents { get; set; }

    }
}