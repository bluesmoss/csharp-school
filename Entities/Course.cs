
using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public ScheduleType Schedule { get; set; }
        public List<Subject> Subject { get; set; }
        public List<Student> Student { get; set; }

        public Course()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}