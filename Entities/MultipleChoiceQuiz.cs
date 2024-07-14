namespace EFCore07.Entities
{
    public class MultipleChoiceQuiz : Quiz
    {
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }

        public char CorrectAnswer { get; set; }
    }
}
