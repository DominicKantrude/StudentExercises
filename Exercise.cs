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

        public override string ToString()
        {
            return $@"
 Exercise: {_exercise}
 Language: {_language}";

        }
    }
}