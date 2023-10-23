using API.RentalReviews.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.RenalReviews.Models
{
    public class Rent
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("id_user")]
        public string Id_User { get; set; }
       
        [BsonElement("resource")]
        public string Resource { get; set; }
        [BsonElement("type_immobile")]
        public string TypeImmobile { get; set; }

        [BsonElement("date_begin")]
        public DateTime DateBegin { get; set; }

        [BsonElement("date_end")]
        public DateTime DateEnd { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }
        
        [BsonElement("location")]
        public Location? Location { get; set; }

        [BsonElement("reviewS")]
        public List<Review>? Reviews { get; set; }

        [BsonElement("comment")]
        public string Comment { get; set; }
       
    }
}
