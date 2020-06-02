using System.Collections.Generic;
using CoreSchool.Entities;

namespace CoreSchool
{
    public class  SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {

        }

        public void Initialize()
        {
            School = new School("Platzi Academy", 2012, SchoolTypes.Secondary, city: "bogota");

            School.Courses =  new List<Course>(){
                new Course() {Name = "101", Schedule = ScheduleType.Morning},
                new Course() {Name = "201",  Schedule = ScheduleType.Morning},
                new Course() {Name = "301",  Schedule = ScheduleType.Morning},
                new Course() {Name = "401",  Schedule = ScheduleType.Afternoon},
                new Course() {Name = "501",  Schedule = ScheduleType.Afternoon},
            };
        }
    }
}