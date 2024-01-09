using System.Text.Json;

namespace Cheap_shark.Models;

internal class FavoriteGames
{
    public string? Name { get; set; }
    public List<Game> gameList { get; }

    public FavoriteGames(string name)
    {
        Name = name;
        gameList = new List<Game>();
    }

    public void AddFavoriteGames(Game game)
    { 
        gameList.Add(game);
    }

    public void ShowFavoriteGames()
    {
        Console.WriteLine($"This is your favorite games -> {Name}");
        foreach (var game in gameList)
        {
            Console.WriteLine($"- {game.Title} - {game.RatingPercent}");
        }
    }

    public void GenerateJsonFile() 
    {
        string json = JsonSerializer.Serialize(new
        { 
            name = Name,
            games = gameList,
        });
        string fileName = $"favorite-games-{Name}.json";
        Console.WriteLine($"The json file was created sucessfully! " +
            $"{Path.GetFullPath(fileName)}");

    }
}
