class Question {
    public string Text{get;set;}
    public string[] Answers{    get;set;}
    public int CorrectAnswerNumber{get;set;}

    public Question(string text, string[] answers, int correctAnswerNumber) {
        Text = text;
        Answers = answers;
        CorrectAnswerNumber = correctAnswerNumber;
    }
}