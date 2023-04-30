using Newtonsoft.Json;

class Game
{
    public Question[] Questions { get; set; }
    public Player Player { get; set; }


    public int QuestionNumber { get; set; }

    public Game(Question[] questions, Player player, int questionNumber)
    {
        Questions = questions;
        Player = player;
        QuestionNumber = questionNumber;
    }

    public void SaveGame()
    {
        using FileStream stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "game.json"), FileMode.OpenOrCreate);
        using StreamWriter writer = new StreamWriter(stream);
        string json = JsonConvert.SerializeObject(this);
        writer.WriteLine(json);

    }
    public static Game GameLoad()
    {
        using FileStream stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "game.json"), FileMode.OpenOrCreate);
        StreamReader reader = new StreamReader(stream);
        string text = reader.ReadToEnd();
        Game game = JsonConvert.DeserializeObject<Game>(text);
        return game;

    }
}