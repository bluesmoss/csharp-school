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

            Dictionary <int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(10, "Alfredo");
            dictionary.Add(23, "Blue");

            foreach (var key in dictionary)
            {
                    WriteLine($"key: {key.Key} Value: {key.Value}");
            }

            Printer.WriteTitle("Dictionary access");
            dictionary[0] = "Moss";
            WriteLine(dictionary[0]);

            Printer.WriteTitle("Another dictionary");
            var dic = new Dictionary<string, string>();
            dic["Luna"] = "Cuerpo celeste";
            WriteLine(dic["Luna"]);
            dic["Luna"] = "Main charcater";
            WriteLine(dic["Luna"]);

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
