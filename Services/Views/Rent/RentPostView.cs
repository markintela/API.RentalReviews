using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using EntityData.Models;

namespace ServicesDomain.Views.Rent
{
    public class RentPostView
    {


        [BsonElement("id_user")]
        [Required(ErrorMessage = "From is required")]
        public string Id_User { get; set; }

        [BsonElement("type_ resource")]
        public string TypeResource { get; set; }

        [BsonElement("type_immobile")]
        public string TypeImmobile { get; set; }

        [BsonElement("date_begin")]
        public DateTime DateBegin { get; set; }

        [BsonElement("date_end")]
        public DateTime DateEnd { get; set; }

        [BsonElement("price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [BsonElement("location")]
        public Location? Location { get; set; }

        //[BsonElement("reviews")]
        //public List<Review>? Reviews { get; set; }

        [BsonElement("comment")]
        public string Comment { get; set; }
    }
}
