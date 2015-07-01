using System;
using EfCodeFirstDataAnnotations.DataAccess;
using EfCodeFirstDataAnnotations.Models;

namespace EfCodeFirstDataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDbContext())
            {
                var newStudent = CreateNewStudent(context);

                var newScheduledCourse = CreateNewScheduledCourse(context);
                newScheduledCourse.Students.Add(newStudent);
                newStudent.ScheduledCourses.Add(newScheduledCourse);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static Student CreateNewStudent(SchoolDbContext context)
        {
            var newStudent = new Student
            {
                FirstName = "Matthew",
                LastName = "Heironimus",
                Birthday = new DateTime(1973, 7, 8),
                EnrollmentDate = new DateTime(2015, 08, 15),
            };

            context.Students.Add(newStudent);
            Console.WriteLine("New student created.");

            return newStudent;
        }

        private static ScheduledCourse CreateNewScheduledCourse(SchoolDbContext context)
        {
            var newInstructor = new Instructor
            {
                FirstName = "Brent",
                LastName = "Baas",
                Department = "Computer Science",
                HireDate = new DateTime(1992, 8, 1),
            };

            var newScheduledCourse = new ScheduledCourse
            {
                Course = new Course
                {
                    CourseNumber = "CS 101",
                    Degree = "Computer Science",
                    Title = "Introduction to Computer Science",
                },
                Instructor = newInstructor,
                ScheduledFor = new Semester {Season = Season.Fall, Year = 2015},
            };
            context.ScheduledCourses.Add(newScheduledCourse);
            Console.WriteLine("New scheduled course created.");

            return newScheduledCourse;
        }
    }
}
