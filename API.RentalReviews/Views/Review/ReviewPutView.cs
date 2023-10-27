using MongoDB.Bson.Serialization.Attributes;

namespace API.RentalReviews.Views.Review
{
    public class ReviewPutView
    {
        [BsonId]
        public string _id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("score")]
        public int Score { get; set; }
    }
}
