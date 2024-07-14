using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore07.Entities
{
    public class Section
    {
        public int Id { get; set; } 
        public string? SectionName { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set;}
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }  
        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public ICollection<Particpants> Particpants { get; set; } = new List<Particpants>();

        public TimeSolt TimeSolt { get; set; }

    }

    public class TimeSolt
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
