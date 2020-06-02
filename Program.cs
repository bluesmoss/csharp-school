using System;
using System.Collections.Generic;
using CoreSchool;
using CoreSchool.Entities;
using static System.Console;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine  =new SchoolEngine();
            engine.Initialize();
            printSchoolCourses(engine.School);

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
    }
}
