
using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public ScheduleType Schedule { get; set; }

        public Course()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}