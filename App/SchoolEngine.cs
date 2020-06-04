using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entities;

namespace CoreSchool
{
    public sealed class  SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {

        }

        public void Initialize()
        {
            School = new School("Platzi Academy", 2012, SchoolType.Secondary, city: "bogota");

            LoadCourses();
            LoadSubjects();
            LoadEvaluations(5);
        }
        public List<BaseSchoolObject> GetSchoolObjects(
            out int countEvaluation,
            out int countStudent,
            out int countSubject,
            out int countCourses,
            bool getEvaluation = true,
            bool getStudent = true,
            bool getSubject = true,
            bool getCourses = true
            )
        {
            countEvaluation = countStudent = countSubject = countCourses = 0;
            var objList = new List<BaseSchoolObject> ();
            objList.Add(School);
            if (getCourses)
            {
                objList.AddRange(School.Courses); 
                countCourses = School.Courses.Count;
            }

            foreach (var course in School.Courses)
            {
                countSubject = course.Subject.Count;
                countStudent = course.Student.Count;
                if (getSubject)
                {
                    objList.AddRange(course.Subject);
                }

                if (getStudent)
                {
                    objList.AddRange(course.Student);
                }

                if (getEvaluation)
                {
                    foreach (var student in course.Student)
                    {
                        objList.AddRange(student.Evaluation);
                        countEvaluation += student.Evaluation.Count;
                    }
                }
            }
            return objList;
        }

        #region Load's Methods
        private void LoadEvaluations(int total)
        {
            foreach (var course in School.Courses)
            {
                foreach (var subject in course.Subject)
                {
                    foreach (var student in course.Student)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        var counter = 0;
                        while ( counter < total)
                        {
                            var evaluation = new Evaluation
                                {
                                    Subject = subject,
                                    Name = $"{subject.Name} Evaluation #{counter + 1}",
                                    Note = (float)(5 * rnd.NextDouble()),
                                    Student = student
                                };
                            student.Evaluation.Add(evaluation);
                            counter++;
                        }
                    }
                }
            }
        }

        private void LoadSubjects()
        {
            foreach(var course in School.Courses)
            {
                var SubjectList = new List<Subject>(){
                    new Subject{Name = "Mathematics"},
                    new Subject{Name = "Phisics"},
                    new Subject{Name = "Spanish"},
                    new Subject{Name = "Arts"},
                    new Subject{Name = "Natural Science"}
                };
                course.Subject = SubjectList;
            }
        }
        private void LoadCourses()
        {
            School.Courses = new List<Course>(){
                new Course() {Name = "101", Schedule = ScheduleType.Morning},
                new Course() {Name = "201",  Schedule = ScheduleType.Morning},
                new Course() {Name = "301",  Schedule = ScheduleType.Morning},
                new Course() {Name = "401",  Schedule = ScheduleType.Afternoon},
                new Course() {Name = "501",  Schedule = ScheduleType.Afternoon},
            };

            Random rmd = new Random();
            foreach (var course in School.Courses)
            {
                var totalRandom = rmd.Next(5,20);
                course.Student = createRandomStudents(totalRandom);
            }
        }
        #endregion
        private List<Student> createRandomStudents(int total)
        {
            string[] firstName = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] secondName = { "Freddy", "Anabel", "Rick", "Morty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var StudentList =   from n1 in firstName
                                from n2 in secondName
                                from a1 in lastName
                                select new Student{ Name = $"{n1} {n2} {a1}" };

            return StudentList.OrderBy((student) => student.UniqueId ).Take(total).ToList();
        }        
    }
}