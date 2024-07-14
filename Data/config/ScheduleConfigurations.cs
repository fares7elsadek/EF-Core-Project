using EFCore07.Entities;
using EFCore07.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore07.Data.config
{
    public class ScheduleConfigurations : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.ToTable("Schedules");

            builder.Property(x => x.Title).HasConversion(
                   x=>x.ToString(),
                   x=> (ScheduleEnum)Enum.Parse(typeof(ScheduleEnum), x)
                );

            
        }

        
    }
}
