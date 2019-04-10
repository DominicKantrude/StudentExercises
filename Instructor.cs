namespace StudentExercises
{
    class Instructor
    {
        private string _firstName;
        private string _lastName;
        private string _slackHandle;

        private Cohort _cohort;



        public void assignExercise(Exercise excercise, Student student)
        {
            student.addExercise(excercise);
        }
        public void setCohort(Cohort cohort)
        {
            _cohort = cohort;
        }


        public Instructor(string firstName, string lastName, string slackHandle)
        {
            _firstName = firstName;
            _lastName = lastName;
            _slackHandle = slackHandle;

        }

        public override string ToString()
        {
            return $@"
 {_firstName} {_lastName}
 Slack: {_slackHandle}";

        }
    }


}