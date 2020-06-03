using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
       public List<Evaluation> Evaluation { get; set; }

        public Student() => UniqueId = Guid.NewGuid().ToString();
    }
}