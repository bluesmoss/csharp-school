using System;
using System.Collections.Generic;
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
            Printer.DrawLine(20);
            Printer.WriteTitle("Polymorphism");

            var testStudent = new Student { Name = "Alfredo Morales"};
            
            BaseSchoolObject ob = testStudent;

            Printer.WriteTitle($"Student:");
            WriteLine($"Student: {testStudent.Name}");
            WriteLine($"Student: {testStudent.UniqueId}");
            WriteLine($"Student: {testStudent.GetType()}");
            Printer.WriteTitle("School Object");
            WriteLine($"Student: {ob.Name}");
            WriteLine($"Student: {ob.UniqueId}");
            WriteLine($"Student: {ob.GetType()}");

            var objDummy = new BaseSchoolObject(){
                Name = "Dummy"
            };
            Printer.WriteTitle("Dummy Object");
            WriteLine($"Student: {objDummy.Name}");
            WriteLine($"Student: {objDummy.UniqueId}");
            WriteLine($"Student: {objDummy.GetType()}");

            var evaluation = new Evaluation() {
                Name = "Mathematics evaluation",
                Note = 4.5f,
            };

            Printer.WriteTitle("Evaluation");
            WriteLine($"Student: {evaluation.Name}");
            WriteLine($"Student: {evaluation.UniqueId}");
            WriteLine($"Student: {evaluation.Note}");
            WriteLine($"Student: {evaluation.GetType()}");

            ob = evaluation;
            Printer.WriteTitle("Evaluation Object");
            WriteLine($"Student: {ob.Name}");
            WriteLine($"Student: {ob.UniqueId}");
            WriteLine($"Student: {ob.GetType()}");

            testStudent = (Student)(BaseSchoolObject)evaluation;

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
