using System;
using CoreSchool.Entities;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Platzi Academy", 2012);
            school.Country = "Colombia";
            school.City = "Bogotá";
            school.SchoolTypes = SchoolTypes.Secondary;
            Console.WriteLine(school);
            Console.WriteLine(school.Name);
        }
    }
}
