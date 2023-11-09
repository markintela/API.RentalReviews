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
    internal class LocationEntityConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Long).IsRequired();
            builder.Property(x => x.Address);
            builder.Property(x => x.Level).IsRequired();
            builder.Property(x => x.Codepost);
        }
    }
}

