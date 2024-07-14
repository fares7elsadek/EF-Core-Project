using EFCore07.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore07.Data.config
{
    internal class OfficeConfigurations : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.ToTable("Offices");
            builder.Property(x => x.OfficeName).HasColumnType("varchar")
                .HasMaxLength(50).IsRequired();
            builder.Property(x => x.OfficeLocation).HasColumnType("varchar")
               .HasMaxLength(50).IsRequired();
            
        }

        
    }
}
