using EFCore07.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore07.Data.config
{
    internal class ParticpantsConfigurations : IEntityTypeConfiguration<Particpants>
    {
        public void Configure(EntityTypeBuilder<Particpants> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.ToTable("Particpants");
            builder.Property(x => x.FName).HasColumnType("varchar")
                .HasMaxLength(50).IsRequired();


            builder.HasDiscriminator<string>("ParticpantType")
                .HasValue<Individual>("INDV")
                .HasValue<Corporate>("CORP");

            builder.Property("ParticpantType").HasColumnType("varchar")
                .HasMaxLength(4);

            builder.Property(x => x.LName).HasColumnType("varchar")
                .HasMaxLength(50).IsRequired();
        }

        
    }
}
