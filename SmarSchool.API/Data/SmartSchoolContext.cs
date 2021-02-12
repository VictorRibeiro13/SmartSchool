using System;
using Microsoft.EntityFrameworkCore;
using SmarSchool.API.Models;

namespace SmartSchool.API.Data {
    public class SmartSchoolContext : DbContext 
    {
        public SmartSchoolContext(DbContextOptions<SmartSchoolContext> options) : base(options) {}

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<StudentSubject> studentsSubjects { get; set; }


        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<StudentSubject>().HasKey(AD => new { AD.StudentId, AD.SubjectId });
        }
    }
}
