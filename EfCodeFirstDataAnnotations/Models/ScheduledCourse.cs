using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirstDataAnnotations.Models
{
    public class ScheduledCourse
    {
        public ScheduledCourse()
        {
            Students = new List<Student>();
        }

        [Key]
        [Column(Order = 1)]
        public string CourseNumber { get; set; }
        public Course Course { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public Semester ScheduledFor { get; set; }
        public IList<Student> Students { get; set; }
    }
}
