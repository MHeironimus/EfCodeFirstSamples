using System.Data.Entity;
using EfCodeFirstDefaultConventions.Models;

namespace EfCodeFirstDefaultConventions.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base()
        {}

        public DbSet<ScheduledCourse> ScheduledCourses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
