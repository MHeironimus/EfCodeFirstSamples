using System;
using System.Collections.Generic;

namespace EfCodeFirstFluentApi.Models
{
    public class ScheduledCourse
    {
        public ScheduledCourse()
        {
            Students = new List<Student>();
        }

        public string CourseNumber { get; set; }
        public Course Course { get; set; }

        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public Semester ScheduledFor { get; set; }
        public IList<Student> Students { get; set; }
    }
}
