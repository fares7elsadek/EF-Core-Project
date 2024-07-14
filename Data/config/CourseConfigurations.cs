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
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.ToTable("Courses");
            //builder.Property(x => x.CourseName).HasMaxLength(255); // nvarchar(255)
            builder.Property(x => x.CourseName).HasColumnType("varchar")
                .HasMaxLength(255).IsRequired();
            builder.Property(x => x.Price).HasPrecision(15, 2);

           
        }

       
    }
}
