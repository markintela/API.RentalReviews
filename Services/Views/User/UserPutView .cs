using MongoDB.Bson.Serialization.Attributes;

namespace ServicesDomain.Views.User
{
    public class UserPutView
    {

        [BsonElement("Name")]
        public string Nome { get; set; }

        [BsonElement("From")]
        public string? From { get; set; }
    }
}
