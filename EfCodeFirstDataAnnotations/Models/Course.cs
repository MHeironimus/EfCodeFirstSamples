using System.ComponentModel.DataAnnotations;

namespace EfCodeFirstDataAnnotations.Models
{
    public class Course
    {
        [Key]
        public string CourseNumber { get; set; }

        public string Title { get; set; }
        public string Degree { get; set; }
    }
}
