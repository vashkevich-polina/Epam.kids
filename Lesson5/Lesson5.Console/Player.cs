class Player
{
    public int Money;
    public int CorrectAnswers;
    public string Name;
    
    public Player(string name, int money, int correctAnswers)
    {
        Money = money;
        CorrectAnswers = correctAnswers;
        Name = name;
    }
}