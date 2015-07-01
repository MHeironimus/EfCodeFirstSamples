using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EfCodeFirstCustomConventions.Models;

namespace EfCodeFirstCustomConventions.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolCustomConventions")
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
