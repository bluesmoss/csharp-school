
using System;
using System.Collections.Generic;
using CoreSchool.Util;

namespace CoreSchool.Entities
{
    public class Course:BaseSchoolObject, IPlace
    {
        public ScheduleType Schedule { get; set; }
        public List<Subject> Subject { get; set; }
        public List<Student> Student { get; set; }
        public string Address { get; set; }

        public void CleanPlace()
        {
            Printer.DrawLine();
            System.Console.WriteLine("Cleaning course...");
            System.Console.WriteLine($"Course: {Name} cleaned");
        }
    }
}