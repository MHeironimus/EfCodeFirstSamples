using System;
using System.Collections.Generic;

namespace EfCodeFirstDefaultConventions.Models
{
#if FOREIGN_KEY_PROPERTY_EXAMPLE

    public class ScheduledCourse
    {
        public ScheduledCourse()
        {
            ScheduledCourseId = Guid.NewGuid();
            Students = new List<Student>();
        }

        public Guid ScheduledCourseId { get; set; }

        public int? CourseId { get; set; }
        public Course Course { get; set; }

        public Instructor Professor { get; set; }
        public Semester ScheduledFor { get; set; }
        public IList<Student> Students { get; set; }
    }

#else

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

#endif
}

