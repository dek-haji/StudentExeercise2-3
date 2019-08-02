using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
            exercise.StudentList.Add(student);
        }

        public Instructor(string firstName, string lastName, string specialty, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialty = specialty;
            Id = id;
        }

    }

}