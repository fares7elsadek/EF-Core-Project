﻿// <auto-generated />
using System;
using EFCore07.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore07.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240714125339_TpC")]
    partial class TpC
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore07.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("EFCore07.Entities.Enrollment", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("ParticpantId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "ParticpantId");

                    b.HasIndex("ParticpantId");

                    b.ToTable("Enrollments", (string)null);
                });

            modelBuilder.Entity("EFCore07.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("EFCore07.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);
                });

            modelBuilder.Entity("EFCore07.Entities.Particpants", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("ParticpantType")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Particpants", (string)null);

                    b.HasDiscriminator<string>("ParticpantType").HasValue("Particpants");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EFCore07.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("EFCore07.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);
                });

            modelBuilder.Entity("EFCore07.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Sections", (string)null);
                });

            modelBuilder.Entity("EFCore07.Entities.Corporate", b =>
                {
                    b.HasBaseType("EFCore07.Entities.Particpants");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JopTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CORP");
                });

            modelBuilder.Entity("EFCore07.Entities.Individual", b =>
                {
                    b.HasBaseType("EFCore07.Entities.Particpants");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfGradutaion")
                        .HasColumnType("int");

                    b.Property<bool>("isIntern")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("INDV");
                });

            modelBuilder.Entity("EFCore07.Entities.MultipleChoiceQuiz", b =>
                {
                    b.HasBaseType("EFCore07.Entities.Quiz");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("OptionA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("multipleChoiceQuizzes");
                });

            modelBuilder.Entity("EFCore07.Entities.TrueAndFalseQuiz", b =>
                {
                    b.HasBaseType("EFCore07.Entities.Quiz");

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.ToTable("trueAndFalseQuizzes");
                });

            modelBuilder.Entity("EFCore07.Entities.Enrollment", b =>
                {
                    b.HasOne("EFCore07.Entities.Particpants", "Particpant")
                        .WithMany()
                        .HasForeignKey("ParticpantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore07.Entities.Section", "ParticpantSection")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Particpant");

                    b.Navigation("ParticpantSection");
                });

            modelBuilder.Entity("EFCore07.Entities.Instructor", b =>
                {
                    b.HasOne("EFCore07.Entities.Office", "office")
                        .WithOne("Instructor")
                        .HasForeignKey("EFCore07.Entities.Instructor", "OfficeId");

                    b.Navigation("office");
                });

            modelBuilder.Entity("EFCore07.Entities.Quiz", b =>
                {
                    b.HasOne("EFCore07.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EFCore07.Entities.Section", b =>
                {
                    b.HasOne("EFCore07.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore07.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.HasOne("EFCore07.Entities.Schedule", "Schedule")
                        .WithMany("Sections")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("EFCore07.Entities.TimeSolt", "TimeSolt", b1 =>
                        {
                            b1.Property<int>("SectionId")
                                .HasColumnType("int");

                            b1.Property<TimeSpan>("EndTime")
                                .HasColumnType("time")
                                .HasColumnName("EndTime");

                            b1.Property<TimeSpan>("StartTime")
                                .HasColumnType("time")
                                .HasColumnName("StartTime");

                            b1.HasKey("SectionId");

                            b1.ToTable("Sections");

                            b1.WithOwner()
                                .HasForeignKey("SectionId");
                        });

                    b.Navigation("Course");

                    b.Navigation("Instructor");

                    b.Navigation("Schedule");

                    b.Navigation("TimeSolt")
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore07.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EFCore07.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EFCore07.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EFCore07.Entities.Schedule", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
