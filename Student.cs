using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    class Student : NSSPerson
    {

        private Cohort _cohort;

        private List<Exercise> _exercises = new List<Exercise>();

        public void addExercise(Exercise exercise)
        {
            _exercises.Add(exercise);
        }

        public Student(string firstName, string lastName, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
        }

        public List<Exercise> excercises
        {
            get { return _exercises;}
        }
        public string lastName
        {
            get { return LastName; }
        }

        public Cohort cohort
        {
            get { return _cohort; }
        }
        public void setCohort(Cohort cohort)
        {
            _cohort = cohort;
        }

        public override string ToString()
        {

            StringBuilder output = new StringBuilder($@"
 {FirstName} {LastName}
 Slack: {SlackHandle}");

            _exercises.ForEach(b => output.Append($"{b}\n"));
            return output.ToString();
        }
    }
}