using System;
using System.Collections.Generic;
using CoreSchool.Util;

namespace CoreSchool.Entities
{
    public class School:BaseSchoolObject, IPlace
    {
        public int CreationYear {get; set;}

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public SchoolType SchoolTypes { get; set; }

        public List<Course> Courses { get; set; }

        //Constructor
        // public School(string name, int year)
        // {
        //     this.name = name;
        //     CreationYear = year;
        // }

        //Constructor
        public School(string name, int year) => (Name, CreationYear) = (name, year);

        //Constructor
        public School(string name, int year, SchoolType types, string country="", string city="") 
        {
            (Name, CreationYear) = (name, year);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {SchoolTypes} {System.Environment.NewLine} Country: {Country}, City: {City}";
        }

        public void CleanPlace()
        {
            Printer.DrawLine();
            System.Console.WriteLine("Cleaning school...");
            foreach (var course in Courses)
            {
                course.CleanPlace();
            }

            Printer.WriteTitle($"School: {Name} cleaned");
            Printer.Beep(500, 500, 3);
        }

    }
}