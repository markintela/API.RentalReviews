using MongoDB.Bson;

namespace API.RentalReviews.Models
{
    public class Signature
    {
        public string Id { get; set; }
        public int SignedById { get; set; }
        public string SignedByName { get; set; }
        public DateTime DateSignature { get; set; }
        public string Comment { get; set; }

        public Signature() {
            Id = ObjectId.GenerateNewId().ToString();
        }
    }
}
