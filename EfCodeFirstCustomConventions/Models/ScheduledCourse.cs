using System;
using System.Collections.Generic;

namespace EfCodeFirstCustomConventions.Models
{
    public class ScheduledCourse
    {
        public ScheduledCourse()
        {
            ScheduledCourseId = Guid.NewGuid();
            Students = new List<Student>();
        }

        public Guid ScheduledCourseId { get; set; }
        public Course Course { get; set; }
        public Instructor Professor { get; set; }
        public Semester ScheduledFor { get; set; }
        public IList<Student> Students { get; set; }
    }
}

