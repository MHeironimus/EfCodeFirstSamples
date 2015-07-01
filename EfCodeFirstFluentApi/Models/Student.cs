using System;
using System.Collections.Generic;

namespace EfCodeFirstFluentApi.Models
{
    public class Student : Person
    {
        public Student()
        {
            ScheduledCourses = new List<ScheduledCourse>();
        }

        public int StudentNumber { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public IList<ScheduledCourse> ScheduledCourses { get; set; }
    }
}
