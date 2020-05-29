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

            var course1 = new Course(){
                Name = "101",
            };
            var course2 = new Course(){
                Name = "201",
            };
            var course3 = new Course(){
                Name = "301",
            };
            System.Console.WriteLine("============");
            System.Console.WriteLine(course1.Name+ ", " + course1.UniqueId);
            System.Console.WriteLine($"{course2.Name}, {course2.UniqueId}");
            System.Console.WriteLine($"{course3.Name}, {course3.UniqueId}");
        }
    }
}
