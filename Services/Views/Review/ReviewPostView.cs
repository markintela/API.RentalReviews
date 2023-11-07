using MongoDB.Bson.Serialization.Attributes;

namespace ServicesDomain.Views.Review
{
    public class ReviewPostView
    {

        [BsonElement("type_review")]
        public string TypeReview { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("score")]
        public int Score { get; set; }

        [BsonElement("date_review")]
        public DateTime DateReview { get; set; }


    }
}
