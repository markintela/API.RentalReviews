using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ServicesDomain.Views.User
{
    public class UserPostView
    {

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("From")]

        [Required(ErrorMessage = "From is required")]
        public string From { get; set; }
    }
}
