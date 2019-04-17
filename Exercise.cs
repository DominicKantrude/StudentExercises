namespace StudentExercises
{
    class Exercise
    {
        private string _exercise;
        private string _language;

        public Exercise(string exercise, string language)
        {
            _exercise = exercise;
            _language = language;
        }

        public string excercise{
            get{return _exercise;}
        }

        public string language{
            get{return _language;}
        }

        public override string ToString()
        {
            return $@"
 Exercise: {_exercise}
 Language: {_language}";

        }
    }
}