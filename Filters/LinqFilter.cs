using Cheap_shark.Models;
using System.Linq;


namespace cheap_shark.Filters;

internal class LinqFilter
{
    public static void FilterAllTitles(List<Game> games)
    {
        var allGamesTitle = games.Select(games => games.Title).Distinct().ToList();
        foreach (var title in allGamesTitle)
        {
            Console.WriteLine($"- {title}");
        }
    }

    public static void FilterGamePrice(List<Game> games, string title)
    {
        var gamePrice = games.Where(games => games.Title!.Equals(title)).ToList();
        Console.WriteLine($"{title} - {gamePrice[0].Price / 100}");
    }

    public static void FilterGameRatingPercent(List<Game> games, string title)
    {
        var gamePrice = games.Where(games => games.Title!.Equals(title)).ToList();
        Console.WriteLine($"{title} - {gamePrice[0].RatingPercent}");
    }
}
