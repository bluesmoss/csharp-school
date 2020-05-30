using System;
using CoreSchool.Entities;
using static System.Console;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Platzi Academy", 2012, SchoolTypes.Secondary, city: "bogota");
            Console.WriteLine(school);

            // var courseArray = new Course[3]{
            //     new Course() {Name = "101"}, new Course() {Name = "201"}, new Course() {Name = "301"}
            // };
            // Course[] courseArray = {
            //     new Course() {Name = "101"}, new Course() {Name = "201"}, new Course() {Name = "301"}
            // };
            school.Courses = new Course[]{
                new Course() {Name = "101"}, new Course() {Name = "201"}, new Course() {Name = "301"}
            };
            printSchoolCourses(school);

        }

        private static void printSchoolCourses(School school)
        {
            WriteLine("-----------------------------");
            WriteLine("School's Courses");
            WriteLine("-----------------------------");

            if (school?.Courses !=  null){
                foreach (var course in school.Courses)
                {
                    WriteLine($"Name {course.Name}, Id {course.UniqueId}");
                }
            }
        }

        private static void PrintCoursesWhile(Course[] courseArray)
        {
            int counter = 0;
            while (counter < courseArray.Length)
            {
                System.Console.WriteLine($"Name {courseArray[counter].Name}, Id {courseArray[counter].UniqueId}");
                counter++;
            }
        }
        private static void PrintCoursesDoWhile(Course[] courseArray)
        {
            int counter = 0;
            do
            {
                System.Console.WriteLine($"Name {courseArray[counter].Name}, Id {courseArray[counter].UniqueId}");
                counter++;
            } while (counter < courseArray.Length);
        }
        private static void PrintCoursesFor(Course[] courseArray)
        {
            for (int i = 0; i < courseArray.Length; i++)
            {
                System.Console.WriteLine($"Name {courseArray[i].Name}, Id {courseArray[i].UniqueId}");
            }
        }
        private static void PrintCoursesForEach(Course[] courseArray)
        {
            foreach (var course in courseArray)
            {
                System.Console.WriteLine($"Name {course.Name}, Id {course.UniqueId}");
            }
        }
    }
}
