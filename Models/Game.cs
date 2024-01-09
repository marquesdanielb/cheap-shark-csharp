using System.Text.Json.Serialization;

namespace Cheap_shark.Models;

internal class Game
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("normalPrice")]
    public string? PriceString { get; set; }

    [JsonPropertyName("steamRatingPercent")]
    public string? RatingPercentString { get; set; }

    [JsonIgnore]
    public double Price
    {
        get
        {
            if (double.TryParse(PriceString, out double result))
            {
                return result;
            }
            else
            {
                return 0.0;
            }
        }
    }

    [JsonIgnore]
    public int RatingPercent
    {
        get
        {
            if (int.TryParse(RatingPercentString, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Price: {Price/100:F2}");
        Console.WriteLine($"Rating: {RatingPercent}%");
    }

}
