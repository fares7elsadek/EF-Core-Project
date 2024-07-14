using EFCore07.Data.config;
using EFCore07.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore07.Data
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Particpants> Students { get; set; }

        public DbSet<Individual> Indivituals { get; set; }
        
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<MultipleChoiceQuiz> multipleChoiceQuizzes { get; set; }

        public DbSet<TrueAndFalseQuiz> trueAndFalseQuizzes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfigurations).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                .Build();
            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
    }
}
