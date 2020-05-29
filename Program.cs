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
        }
    }
}
