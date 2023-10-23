using MongoDB.Bson.Serialization.Attributes;

namespace API.RentalReviews.Views.User
{
    public class UserPostView
    {

        [BsonElement("Name")]
        public string Nome { get; set; }

        [BsonElement("From")]
        public string? From { get; set; }
    }
}
