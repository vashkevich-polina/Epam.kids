
Console.WriteLine("Добро пожаловать в игру \"Смешарики\"!");
Console.WriteLine("Введите имя игрока:");
var playerName = Console.ReadLine();
var player = new Player(playerName, money: 10, 0);

var questions = new[] {
    new Question("Какому смешарику на голову упала сосулька?", new [] {"Ёжик", "Крош", "Лосяш", "Совунья"}, 3),
    new Question("Кто любит смотреть на горы?", new [] {"Бараш", "Пин", "Нюша", "Совунья"}, 1),
    new Question("Кто придумал рецепт хорошего отдыха?", new [] {"Нюша", "Крош", "Лосяш", "Совунья"}, 4),
    new Question("Кто любит мёд?", new [] {"Кар-Карыч", "Копатыч", "Биби", "Ёжик"}, 2),
    new Question("Кто собрал коллекцию фантиков?", new [] {"Ёжик", "Крош", "Пин", "Совунья"}, 1)
};

var game = new Game(questions, player);
StartGame(game);


void StartGame(Game game)
{
    bool continuePlaying = true;
    int questionNumber = 0;
    while (questionNumber < game.Questions.Length && continuePlaying)
    {
        var question = game.Questions[questionNumber];
        Console.WriteLine(question.Text);
        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {question.Answers[i]}");
        }

        int answerNumber = GetAnswerNumber();

        if (question.CorrectAnswerNumber == answerNumber)
        {
            game.Player.CorrectAnswers++;
            Console.WriteLine("Правильно!");
            game.Player.Money = game.Player.Money * 2;
        }
        else
        {
            Console.WriteLine("Неправильно!");
        }

        questionNumber++;
        if (questionNumber < game.Questions.Length)
            continuePlaying = GetContinuePlaying();
    }
    Console.WriteLine($"Игра окончена. Вы заработали {game.Player.Money}. Правильных ответов: {game.Player.CorrectAnswers}");
}

int GetAnswerNumber()
{
    bool success = false;
    int answerNumber = 0;
    do
    {
        Console.WriteLine("Введите номер ответа:");
        string answer = Console.ReadLine();
        if (int.TryParse(answer, out answerNumber) && answerNumber <= 4 && answerNumber >= 1)
        {
            success = true;
        }

    }
    while (!success);
    return answerNumber;
}

bool GetContinuePlaying()
{
    bool success = false;
    int answerNumber = 0;
    do
    {
        Console.WriteLine("Хотите продолжить игру? 1 - Да, 2 - Нет");
        string answer = Console.ReadLine();
        if (int.TryParse(answer, out answerNumber) && answerNumber <= 2 && answerNumber >= 1)
        {
            success = true;
        }

    }
    while (!success);

    if (answerNumber == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
