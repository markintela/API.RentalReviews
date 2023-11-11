using EntityData.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.EntityConfiguration
{
    internal class RentEntityConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.ToTable("Rents");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdUser).IsRequired();
            builder.Property(x => x.IdLocation).IsRequired();
            builder.Property(x => x.TypeResource).IsRequired();
            builder.Property(x => x.TypeImmobile).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,4)"); ;
            builder.Property(x => x.DateBegin).IsRequired();
            builder.Property(x => x.DateEnd).IsRequired();
            builder.Property(x => x.DateCreation).IsRequired();  
            builder.Property(x => x.LastUpdate).IsRequired(false);
            builder.Property(x => x.Comment);

            //Mapping Fk´s
            builder.HasOne(x => x.Location)
                   .WithMany()
                   .HasForeignKey(x => x.IdLocation);

            builder.HasOne(x => x.User)
                   .WithMany()
                   .HasForeignKey(x => x.Id);

        
        }
    }
}

