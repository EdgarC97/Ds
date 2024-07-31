using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class School
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            if (course != null)
            {
                courses.Add(course);
            }
        }
        public void FindAndDisplayCoursesByName(string name)
        {
            var foundCourses = courses.Where(c => c?.Name != null && c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            .ToList();

            if (foundCourses.Any())
            {
                foreach (var course in foundCourses)
                {
                    Console.WriteLine($"Course found: {course.Name}, Code: {course.Code}, Duration: {course.Duration} hours");
                }
            }
            else
            {
                Console.WriteLine($"No courses found with name: {name}");
            }

        }
    }
}