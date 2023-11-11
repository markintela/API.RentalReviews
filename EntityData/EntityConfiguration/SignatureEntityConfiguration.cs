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
    internal class SignatureEntityConfiguration : IEntityTypeConfiguration<Signature>
    {
        public void Configure(EntityTypeBuilder<Signature> builder)
        {
            builder.ToTable("Signatures");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.SignedById).IsRequired();
            builder.Property(x => x.SignedByName).IsRequired();
            builder.Property(x => x.DateCreation).IsRequired();
            builder.Property(x => x.LastUpdate).IsRequired(false);
            builder.Property(x => x.Comment);

        }
    }
}

