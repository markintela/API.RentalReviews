using EntityData.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityData.Models
{
    public class Signature : EntityBase<Guid>
    {
      
        [ForeignKey("IdReview")]
        public Guid IdReview { get; set; }

        [ForeignKey("IdUser")]
        public Guid SignedById { get; set; }
        public string SignedByName { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }

        //FK´s to access related tables
        [ForeignKey("IdReview")]
        public virtual Review Review { get; set; }

        public Signature()
        {
            IsActive = true;
            DateCreation = DateTime.Now;
        }

    }
}
