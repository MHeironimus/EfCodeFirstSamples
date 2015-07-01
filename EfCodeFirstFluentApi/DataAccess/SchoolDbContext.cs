using System.Data.Entity;
using EfCodeFirstFluentApi.Models;

namespace EfCodeFirstFluentApi.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolFluentApi")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Default Schema
            modelBuilder.HasDefaultSchema("Institution");

            // Configure Tables
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<ScheduledCourse>().ToTable("ScheduledClass");

            // Configure Primary Keys
            modelBuilder.Entity<Course>().HasKey<string>(course => course.CourseNumber);
            modelBuilder.Entity<Student>().HasKey<int>(student => student.StudentNumber);
            modelBuilder.Entity<ScheduledCourse>().HasKey(scheduledCourse => 
                new { scheduledCourse.CourseNumber, scheduledCourse.InstructorId });

            // Configure Many-to-Many Relationship
            modelBuilder.Entity<Student>()
                .HasMany<ScheduledCourse>(student => student.ScheduledCourses)
                .WithMany(scheduledCourse => scheduledCourse.Students)
                .Map(studentClass =>
                {
                    studentClass.MapLeftKey("StudentNumber");
                    studentClass.MapRightKey("CourseNumber", "InstructorId");
                    studentClass.ToTable("StudentClass");
                });
        }

        public DbSet<ScheduledCourse> ScheduledCourses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
