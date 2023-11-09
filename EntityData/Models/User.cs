using EntityData.Common;
using System.ComponentModel.DataAnnotations;

namespace EntityData.Models
{
    public class User : EntityBase<Guid>
    {
        public string Nome { get; set; }
        public string From { get; set; }
    }
}