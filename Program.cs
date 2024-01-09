using cheap_shark.Filters;
using Cheap_shark.Models;
using System.Collections.Generic;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        var games = JsonSerializer.Deserialize<List<Game>>(resposta)!;
        //LinqFilter.FilterAllTitles(games);
        //LinqFilter.FilterGamePrice(games, "The Testament of Sherlock Holmes");
        //LinqOrder.ShowGamesOrderByTitle(games);
        //LinqOrder.ShowGamesOrderByPrice(games);
        //LinqOrder.ShowGamesOrderByRatingPercent(games);
        var DanielFavoriteGames = new FavoriteGames("Daniel");
        DanielFavoriteGames.AddFavoriteGames(games[0]);
        DanielFavoriteGames.AddFavoriteGames(games[1]);
        DanielFavoriteGames.AddFavoriteGames(games[2]);
        DanielFavoriteGames.AddFavoriteGames(games[3]);
        DanielFavoriteGames.AddFavoriteGames(games[4]);

        DanielFavoriteGames.ShowFavoriteGames();
        DanielFavoriteGames.GenerateJsonFile();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Acho que aconteceu alguma coisa: {ex.Message}");
    }
}
