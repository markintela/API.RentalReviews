using System.ComponentModel.DataAnnotations.Schema;
using EntityData.Common;

namespace EntityData.Models
{
    public class Review : EntityBase<Guid>
    {

        [ForeignKey("IdRent")]
        public Guid IdRent { get; set; }
        public string TypeReview { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool IsActive { get; set; }

        //FK´s to access related tables
        [ForeignKey("IdRent")]
        public virtual Rent Rent { get; set; }

        public Review()
        {
            IsActive = true;
            DateCreation = DateTime.Now;
        }
    }
}
