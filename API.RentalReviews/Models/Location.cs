using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.RentalReviews.Models
{
    public class Location
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("latitude")]
        public double Lat { get; set; }

        [BsonElement("longitude")]
        public double Long { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("level")]
        public string Level { get; set; }

        [BsonElement("code_post")]
        public string Codepost { get; set; }


        public Location()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }
    }
}
