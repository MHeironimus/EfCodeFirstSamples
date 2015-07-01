using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EfCodeFirstDataAnnotations.Models;

namespace EfCodeFirstDataAnnotations.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolDataAnnotations")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Do not use plural table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<ScheduledCourse> ScheduledCourses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
