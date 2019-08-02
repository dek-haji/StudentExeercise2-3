using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {

        public Cohort(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public List<Instructor> InstructorList { get; set; } = new List<Instructor>();
    }
}