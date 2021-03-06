﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(SmartSchoolContext))]
    partial class SmartSchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("SmarSchool.API.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastName = "Kent",
                            Name = "Marta",
                            Phone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "Isabela",
                            Name = "Paula",
                            Phone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            LastName = "Antonia",
                            Name = "Laura",
                            Phone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            LastName = "Maria",
                            Name = "Luiza",
                            Phone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            LastName = "Machado",
                            Name = "Lucas",
                            Phone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            LastName = "Alvares",
                            Name = "Pedro",
                            Phone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            LastName = "José",
                            Name = "Paulo",
                            Phone = "9874512"
                        });
                });

            modelBuilder.Entity("SmarSchool.API.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("studentsSubjects");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 1,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 1,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 5
                        });
                });

            modelBuilder.Entity("SmarSchool.API.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matemática",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Física",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Português",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Inglês",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Programação",
                            TeacherId = 5
                        });
                });

            modelBuilder.Entity("SmarSchool.API.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lauro"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ronaldo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rodrigo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmarSchool.API.Entities.StudentSubject", b =>
                {
                    b.HasOne("SmarSchool.API.Entities.Student", "Student")
                        .WithMany("StudentsSubject")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmarSchool.API.Entities.Subject", "Subject")
                        .WithMany("StudentsSubject")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SmarSchool.API.Entities.Subject", b =>
                {
                    b.HasOne("SmarSchool.API.Entities.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SmarSchool.API.Entities.Student", b =>
                {
                    b.Navigation("StudentsSubject");
                });

            modelBuilder.Entity("SmarSchool.API.Entities.Subject", b =>
                {
                    b.Navigation("StudentsSubject");
                });

            modelBuilder.Entity("SmarSchool.API.Entities.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
