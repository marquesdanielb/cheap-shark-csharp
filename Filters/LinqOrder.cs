using Cheap_shark.Models;
using System.Linq;

namespace cheap_shark.Filters
{
    internal class LinqOrder
    {
        public static void ShowGamesOrderByTitle(List<Game> games)
        {
            var gamesTitleOrdered = games.OrderBy(games
                => games.Title).Select(games
                => games.Title).Distinct().ToList();
            Console.WriteLine("Game's titles [A - Z]");
            foreach (var title in gamesTitleOrdered)
            {
                Console.WriteLine($"- {title}");
            }
        }

        public static void ShowGamesOrderByPrice(List<Game> games)
        {
            var gamesPriceOrdered = games.GroupBy(game => game.Title)
                .Select(group => group.First())
                .OrderByDescending(game => game.Price)
                .ToList();
            Console.WriteLine("Game's Prices");
            foreach (var game in gamesPriceOrdered)
            {
                Console.WriteLine($"{game.Title} - {game.Price/100:F2}");
            }
        }

        public static void ShowGamesOrderByRatingPercent(List<Game> games)
        {
            var gamesPriceOrdered = games.GroupBy(game => game.Title)
                .Select(group => group.First())
                .OrderByDescending(game => game.RatingPercent)
                .ToList();
            Console.WriteLine("Game's Rating Percent");
            foreach (var game in gamesPriceOrdered)
            {
                Console.WriteLine($"{game.Title} - {game.RatingPercent}");
            }
        }
    }
}
