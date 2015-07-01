using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfCodeFirstDataAnnotations.Models
{
    public class Student : Person
    {
        public Student()
        {
            ScheduledCourses = new List<ScheduledCourse>();
        }

        [Key]
        public int StudentNumber { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public IList<ScheduledCourse> ScheduledCourses { get; set; }
    }
}
