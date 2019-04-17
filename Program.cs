
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {

        static void Main(string[] args)
        {

            Exercise firstExercise = new Exercise("do sql", "SQL");
            Exercise secondExercise = new Exercise("do C#", "C#");
            Exercise thirdExercise = new Exercise("do .Javascript", "Javascript");
            Exercise fourthExercise = new Exercise("do other Javascript", "Javascript");

            List<Exercise> exercises = new List<Exercise>() { firstExercise, secondExercise, thirdExercise, fourthExercise };

            Cohort firstCohort = new Cohort("Cohort 30");
            Cohort secondCohort = new Cohort("Cohort 29");
            Cohort thirdCohort = new Cohort("Cohort 28");

            List<Cohort> cohorts = new List<Cohort>() { firstCohort, secondCohort, thirdCohort };

            Student firstStudent = new Student("Dom", "kantrude", "slack/dom");
            Student secondStudent = new Student("Billy", "bob", "slack/bill");
            Student thirdStudent = new Student("guy", "man", "slack/guyman");
            Student fourthStudent = new Student("girl", "woman", "slack/girlman");


            List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent, fourthStudent };

            Instructor firstInstructor = new Instructor("steve", "steveslastname", "slack/steve");
            Instructor secondInstructor = new Instructor("jenna", "jennaslastname", "slack/jenna");
            Instructor thirdInstructor = new Instructor("kim", "kimslastname", "slack/kim");

            List<Instructor> instructors = new List<Instructor>() { firstInstructor, secondInstructor, thirdInstructor };

            firstCohort.assignStudentToCohort(firstStudent);
            secondCohort.assignStudentToCohort(secondStudent);
            thirdCohort.assignStudentToCohort(thirdStudent);
            firstCohort.assignStudentToCohort(fourthStudent);

            firstCohort.assignInstructorToCohort(firstInstructor);
            secondCohort.assignInstructorToCohort(secondInstructor);
            thirdCohort.assignInstructorToCohort(thirdInstructor);


            firstInstructor.assignExercise(firstExercise, firstStudent);
            firstInstructor.assignExercise(secondExercise, firstStudent);
            secondInstructor.assignExercise(secondExercise, secondStudent);
            thirdInstructor.assignExercise(thirdExercise, thirdStudent);


            Console.WriteLine(firstCohort);





            /************************student stuff 2 */

            // List exercises for the JavaScript language by using the Where() LINQ method.

            List<Exercise> javascriptExercises = exercises.Where(excercise => excercise.language == "Javascript").ToList();

            foreach (var exercise in javascriptExercises)
            {
                Console.WriteLine($"{exercise}");
            }

            //List students in a particular cohort by using the Where() LINQ method.

            List<Student> stundentsInCertainCohort = students.Where(student => student.cohort.name == "Cohort 30").ToList();

            foreach (var student in stundentsInCertainCohort)
            {
                Console.WriteLine($"{student}");
            }

            //List instructors in a particular cohort by using the Where() LINQ method.


            //Sort the students by their last name.
            List<Student> stundentsSortedByLastName = students.OrderBy(student => student.lastName).ToList();

            foreach (var student in stundentsSortedByLastName)
            {
                Console.WriteLine($"{student.lastName}");
            }

            //Display any students that aren't working on any exercises (Make sure one of your student instances don't
            //have any exercises. Create a new student if you need to.)

            List<Student> studentsWithNoExercise = students.Where(student => student.excercises.Count == 0).ToList();

            foreach (var student in studentsWithNoExercise)
            {
                Console.WriteLine($"{student}");
            }
            //Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            var dat = students.Max(student => student.excercises.Count());

            Console.WriteLine(dat);
            //String maxSingerName = singers.Max(s => s.FirstName);
            // foreach (var da in dat)
            // {
            //     Console.WriteLine($"{da}");
            // }

            //How many students in each cohort?

            // foreach (var cohort in cohorts)
            // {
            //     Console.WriteLine($"{cohort.name}: {cohort.studentsInCohort.Count()} students");
            // }
        }

    }
}
