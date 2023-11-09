using EntityData.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityData.Models
{
    public class Signature : EntityBase<Guid>
    {
        [ForeignKey("SignedById")]
        public Guid SignedById { get; set; }
        public string SignedByName { get; set; }
        public DateTime DateSignature { get; set; }
        public string Comment { get; set; }

    }
}
