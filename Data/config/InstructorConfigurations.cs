using EFCore07.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore07.Data.config
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x =>x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.ToTable("Instructors");
            builder.Property(x => x.Name).HasColumnType("varchar")
                .HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.office)
                .WithOne(x => x.Instructor)
                .HasForeignKey<Instructor>(x => x.OfficeId)
                .IsRequired(false);

            builder.HasIndex(x => x.OfficeId).IsUnique();

           
        }

        
    }
}
