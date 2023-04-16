class Question {
    public string Text;
    public string[] Answers;
    public int CorrectAnswerNumber;

    public Question(string text, string[] answers, int correctAnswerNumber) {
        Text = text;
        Answers = answers;
        CorrectAnswerNumber = correctAnswerNumber;
    }
}