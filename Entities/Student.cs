using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Student: BaseSchoolObject
    {
        public List<Evaluation> Evaluation { get; set; } = new List<Evaluation>();

    }
}