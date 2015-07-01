using System;
using System.Collections.Generic;

namespace EfCodeFirstDefaultConventions.Models
{
    public class Instructor : Person
    {
        public Instructor()
        {
            InstructorId = Guid.NewGuid();
            ScheduledCourses = new List<ScheduledCourse>();
        }

        public Guid InstructorId { get; set; }
        public string Department { get; set; }
        public DateTime HireDate { get; set; }
        public IList<ScheduledCourse> ScheduledCourses { get; set; } 
    }
}
