using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    class Cohort
    {
        private string _name;
        public Cohort(string name)
        {
            _name = name;
        }
        List<Student> studentsInCohort = new List<Student>();
        List<Instructor> instructorsInCohort = new List<Instructor>();


        public void assignInstructorToCohort(Instructor instructor)
        {
            instructorsInCohort.Add(instructor);
            instructor.setCohort(this);
        }
        public void assignStudentToCohort(Student student)
        {
            studentsInCohort.Add(student);
            student.setCohort(this);
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder($@"
****************************************************
*******  COHORT : {_name}
****************************************************

INSTRUCTORS:
");

            instructorsInCohort.ForEach(b => output.Append($"{b}\n"));

            output.Append(" Students: ");
            studentsInCohort.ForEach(b => output.Append($"{b}\n")

            );

            return output.ToString();
        }
    }
}