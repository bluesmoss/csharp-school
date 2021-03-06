﻿using System;
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
            AppDomain.CurrentDomain.ProcessExit += EventAction;
            AppDomain.CurrentDomain.ProcessExit += (o, a) => Printer.Beep(100, 1000, 1);

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

            var dictmp = engine.getObjectDictionary();
            engine.PrintDictionary(dictmp, true);
        }

        private static void EventAction(object sender, EventArgs e)
        {
            Printer.WriteTitle("Exit");
            Printer.Beep(3000, 1000, 3);
            Printer.WriteTitle("Exit Completed");
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
