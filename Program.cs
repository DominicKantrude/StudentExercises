using System;

namespace StudentExercises
{
    class Program
    {

        static void Main(string[] args)
        {

            Exercise firstExercise = new Exercise("do sql", "SQL");
            Exercise secondExercise = new Exercise("do C#", "C#");
            Exercise thirdExercise = new Exercise("do .net stuff", ".net");
            Exercise fourthExercise = new Exercise("do html", "HTML");

            Cohort firstCohort = new Cohort("Cohort 30");
            Cohort secondCohort = new Cohort("Cohort 29");
            Cohort thirdCohort = new Cohort("Cohort 28");

            Student firstStudent = new Student("Dom", "kantrude", "slack/dom");
            Student secondStudent = new Student("Billy", "bob", "slack/bill");
            Student thirdStudent = new Student("guy", "man", "slack/guyman");
            Student fourthStudent = new Student("girl", "woman", "slack/girlman");

            Instructor firstInstructor = new Instructor("steve", "steveslastname", "slack/steve");
            Instructor secondInstructor = new Instructor("jenna", "jennaslastname", "slack/jenna");
            Instructor thirdInstructor = new Instructor("kim", "kimslastname", "slack/kim");

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

        }


    }
}
