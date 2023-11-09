using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityData.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityData.Models
{
    public class Rent : EntityBase<Guid>
    {
        [ForeignKey("IdUser")]
        public Guid? IdUser { get; set; }

        [ForeignKey("IdLocation")]
        public Guid IdLocation { get; set; }
        public Guid TypeResource { get; set; }
        public Guid TypeImmobile { get; set; }
        public decimal Price { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateCreation { get; set; }
        public string Comment { get; set; }

        //FK´s to access related tables
        [ForeignKey("IdLocation")]
        public virtual Location Location { get; set; }

    }
}
