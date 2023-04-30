class Player
{
    public int Money{get;set;}
    public int CorrectAnswers{get;set;}
    public string Name{get;set;}
    
    public Player(string name, int money, int correctAnswers)
    {
        Money = money;
        CorrectAnswers = correctAnswers;
        Name = name;
    }
}