using System.ComponentModel.DataAnnotations;
using EntityData.Models;

namespace ServicesDomain.Views.Rent
{
    public class RentPostView
    {
        public string Id_User { get; set; }
        public string TypeResource { get; set; }
        public string TypeImmobile { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Price { get; set; }
        public Location? Location { get; set; }
        public string Comment { get; set; }
    }
}
