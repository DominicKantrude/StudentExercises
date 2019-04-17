namespace StudentExercises
{
    public class NSSPerson
    {
        private string _firstName;
        private string _lastName;
        private string _slackHandle;



        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }

        public string SlackHandle
        {
            get
            {
                return _slackHandle;
            }
            set
            {
                _slackHandle = value;
            }

        }
    }
}