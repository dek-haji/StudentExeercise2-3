using System;
using System.Collections.Generic;
using System.Linq;
// using StudentExercise;

namespace StudentExercises
{
    class Program
    {

       public static void Main(string[] args)
        {
            // create 4, or more exercise
            Exercise classExercise = new Exercise("Class Exercise", "JavaScript", 1);
            Exercise dictionaryExercise = new Exercise("Dictionary List", "C#", 2);
            Exercise reactExercise = new Exercise("React Exercise", "React", 3);
            Exercise capstone = new Exercise("Capstone ", "Java", 4);
            Exercise jsonServer = new Exercise("JsonServer Data ", "JavaScript", 5);
            Exercise journalEntries = new Exercise("Journal Entries", "C#", 6);
            Exercise sylyingSheet = new Exercise("Sylying Sheet", "React", 7);
            Exercise documentsModel = new Exercise("Documents Model ", "Java", 8);


            // create 3 or more cohort
            Cohort c31 = new Cohort("Cohort 31", 31);
            Cohort c30 = new Cohort("Cohort 30", 30);
            Cohort c32 = new Cohort("Cohort 32", 32);
            Cohort c33 = new Cohort("Cohort 31", 33);

            //create 4 or more Students and assign them  to 1 assignment


            Student Hutha = new Student("Hutha", "Jamal", 0);
            Student Dek = new Student("Dek", "Abdi", 1);
            Student Dan = new Student("Dan", "marley", 1);
            Student Deeq = new Student("Deeq", "Ahmed", 1);

            // slack handle
            Hutha.Slackhandle = "hutha@slack.com";
            Dek.Slackhandle = "dek@slack.com";
            Deeq.Slackhandle = "deeq@slack.com";
            Dan.Slackhandle = "dan@slack.com";


            //add to cohort
            Dek.Cohor = c31;
            Dan.Cohor = c30;
            Deeq.Cohor = c32;
            Hutha.Cohor = c31;

            //create instructors

            Instructor Jisi = new Instructor("Jisi", "David", "Lead Instructor", 1);
            Instructor Andy = new Instructor("Andy", "Collin", "2nd Lead Instructor", 2);
            Instructor Adam = new Instructor("Adam", "haha", "3rd Lead Instructor", 3);

            //slack contact
            Adam.SlackHandle = "Adamhaha@slack.com";
            Andy.SlackHandle = "andyCollin@slack.com";
            Jisi.SlackHandle = "jisiDavid@slack.com";

            // Have each Student assign 2 exercises to each student
            Jisi.AssignExercise(Dek, classExercise);
            Jisi.AssignExercise(Dek, dictionaryExercise);
            Andy.AssignExercise(Deeq, capstone);
            Andy.AssignExercise(Hutha, jsonServer);
            Adam.AssignExercise(Dan, reactExercise);
            Adam.AssignExercise(Dek, documentsModel);
            Jisi.AssignExercise(Hutha, dictionaryExercise);
            Andy.AssignExercise(Deeq, journalEntries);

            //create list of student
            List<Student> students = new List<Student>()
            {
                Deeq, Dek, Dan, Hutha
            };
            //create list of exercise
            List<Exercise> exercises = new List<Exercise>()
            {
                documentsModel,journalEntries,documentsModel,reactExercise,
                jsonServer,capstone, classExercise, dictionaryExercise

            };
            //Console.WriteLine($"hahahaha haha {documentsModel.ExerciseType}");

            foreach (Student student in students)
            {
                student.getFullNameAddExercise(student);
                Console.WriteLine(" ");

            }


            //List exercises for the JavaScript language by using the Where() LINQ method.

           IEnumerable<Exercise> jsLanguage = from js in exercises
                                               where js.ExerciseType == "JavaScript"
                                              select js;
            foreach (Exercise c in jsLanguage)
            {
                Console.WriteLine($"there is : {c.ExerciseName} ");
            }
        }

    }
}
