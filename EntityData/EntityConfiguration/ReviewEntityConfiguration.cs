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
    internal class ReviewEntityConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.TypeReview).IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.Score).IsRequired();
            builder.Property(x => x.DateCreation).IsRequired();

            //Mapping Fk´s
            builder.HasOne(x => x.Signature)
                .WithMany()
                .HasForeignKey(x => x.IdSignature);
        }
    }
}

