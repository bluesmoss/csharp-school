using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool;
using CoreSchool.Entities;
using CoreSchool.Util;
using static System.Console;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine  =new SchoolEngine();
            engine.Initialize();
            Printer.WriteTitle("Welcome to the School");
            //Printer.Beep(10000,500, 10);
            printSchoolCourses(engine.School);

            var objectList = engine.GetSchoolObjects();

           // engine.School.CleanPlace();

        }

        private static void printSchoolCourses(School school)
        {
            Printer.WriteTitle("School's Courses");

            if (school?.Courses !=  null){
                foreach (var course in school.Courses)
                {
                    WriteLine($"Name {course.Name}, Id {course.UniqueId}");
                }
            }
        }
    }
}
