using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.RentalReviews.Models
{
    public class Location
    {

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

    
    }
}
