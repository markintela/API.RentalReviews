using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Models
{
    public class Rent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("id_user")]
        public string Id_User { get; set; }

        [BsonElement("type_resource")]
        public string TypeResource { get; set; }

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

        [BsonElement("reviews")]
        public List<Review> Reviews { get; set; } = new List<Review>();

        [BsonElement("comment")]
        public string Comment { get; set; }


    }
}
