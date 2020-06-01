using System;
using System.Collections.Generic;
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

            // school.Courses = new Course[]{
            //     new Course() {Name = "101"}, new Course() {Name = "201"}, new Course() {Name = "301"}
            // };

            school.Courses =  new List<Course>(){
                new Course() {Name = "101", Schedule = ScheduleType.Morning}, new Course() {Name = "201",  Schedule = ScheduleType.Morning}, new Course() {Name = "301",  Schedule = ScheduleType.Morning}
            };
            
            school.Courses.Add(  new Course {Name = "102", Schedule = ScheduleType.Afternoon});
            school.Courses.Add(  new Course {Name = "202", Schedule = ScheduleType.Afternoon});

            var otherCollection =  new List<Course>(){
                new Course() {Name = "401", Schedule = ScheduleType.Morning}, new Course() {Name = "501",  Schedule = ScheduleType.Morning}, new Course() {Name = "502",  Schedule = ScheduleType.Morning}
            };

            otherCollection.Clear(); //Delete elements

            school.Courses.AddRange(otherCollection);

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
