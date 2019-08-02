using System;
using System.Collections.Generic;

namespace StudentExercises
{

    public class Exercise
    {
        public Exercise(string exerciseName, string exerciseType, int id)
        {
            ExerciseName = exerciseName;
            ExerciseType = exerciseType;
            Id = id;


        }
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseType { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public void ListStudentOnExercise(List<Student> students)
        {
            Console.WriteLine($"Here is the Students on {this.ExerciseName}:");
            foreach (Student student in students)
            {
                foreach (Exercise exercise in student.ExerciseList)
                {
                    if (exercise.Equals(this))
                    {
                        StudentList.Add(student);
                        Console.WriteLine(student.getFullName());
                    }
                }
            }
        }
    }
}