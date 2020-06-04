
using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Course: BaseSchoolObject
    {
        public ScheduleType Schedule { get; set; }
        public List<Subject> Subject { get; set; }
        public List<Student> Student { get; set; }

    }
}