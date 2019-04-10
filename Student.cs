using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _slackHandle;
        private Cohort _cohort;

        private List<Exercise> exercises = new List<Exercise>();

        public void addExercise(Exercise exercise)
        {
            exercises.Add(exercise);
        }

        public Student(string firstName, string lastName, string slackHandle)
        {
            _firstName = firstName;
            _lastName = lastName;
            _slackHandle = slackHandle;
        }

        public void setCohort(Cohort cohort)
        {
            _cohort = cohort;
        }

        public override string ToString()
        {

            StringBuilder output = new StringBuilder($@"
 {_firstName} {_lastName}
 Slack: {_slackHandle}");

            exercises.ForEach(b => output.Append($"{b}\n"));
            return output.ToString();
        }
    }
}