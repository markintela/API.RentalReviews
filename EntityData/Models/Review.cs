using System.ComponentModel.DataAnnotations.Schema;
using EntityData.Common;

namespace EntityData.Models
{
    public class Review : EntityBase<Guid>
    {
        [ForeignKey("IdSignature")]
        public Guid IdSignature { get; set; }
        public string TypeReview { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime LastUpdate { get; set; }

        //FK´s to access related tables
        [ForeignKey("IdSignature")]
        public virtual Signature Signature { get; set; }
    }
}
