using System;
using CoreSchool.Entities;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Platzi Academy", 2012, SchoolTypes.Secondary, city:"bogota");
            Console.WriteLine(school);

            var courseArray = new Course[3];
            
            courseArray[0] = new Course()
                            {
                                Name = "101",
                            };
            var course2 = new Course(){
                Name = "201",
            };

            courseArray[1]  = course2;

            courseArray[2] = new Course
                            {
                                Name = "301",
                            };
            System.Console.WriteLine("============");
            PrintCourses(courseArray);
        }

        private static void PrintCourses(Course[] courseArray)
        {
            int counter = 0;
            while (counter < courseArray.Length)
            {
                System.Console.WriteLine($"Name {courseArray[counter].Name}, Id {courseArray[counter].UniqueId}");
                counter++;
            }
        }
    }
}
