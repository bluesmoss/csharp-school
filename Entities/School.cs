using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class School
    {
        string name;
        public string Name{
            get{ return "Copy: " + name;}
            set{ name = value.ToUpper();}
        }

        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public int CreationYear {get; set;}

        public string Country { get; set; }

        public string City { get; set; }

        public SchoolTypes SchoolTypes { get; set; }

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
        public School(string name, int year, SchoolTypes types, string country="", string city="") 
        {
            (Name, CreationYear) = (name, year);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {SchoolTypes} {System.Environment.NewLine} Country: {Country}, City: {City}";
        }

    }
}