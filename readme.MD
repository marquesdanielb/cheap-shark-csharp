# Architecture and Design Documentation - Cheap Shark

## Introduction

The Cheap Shark project is an application that consumes the Cheap Shark API to provide information about games and allows the organization of favorite games.

## Class Modeling

### Class Game (Cheap_shark.Models.Game)

The Game class represents a game and contains the following properties:

- `Title`: Game title.
- `PriceString`: Game price value in string format.
- `RatingPercentString`: Game rating percentage in string format.
- `Price`: Game price value in double format (calculated from `PriceString`).
- `RatingPercent`: Game rating percentage in integer format (calculated from `RatingPercentString`).

Methods:

- `ShowDetails()`: Displays game details, including title, price, and rating percentage.

### Class FavoriteGames (Cheap_shark.Models.FavoriteGames)

The FavoriteGames class represents a list of favorite games associated with a specific name.

Properties:

- `Name`: Name associated with the list of favorite games.
- `gameList`: List of favorite games.

Methods:

- `AddFavoriteGames(Game game)`: Adds a game to the list of favorite games.
- `ShowFavoriteGames()`: Displays the list of favorite games with their titles and rating percentages.
- `GenerateJsonFile()`: Generates a JSON file containing the name and the list of favorite games.

### Class LinqFilter (cheap_shark.Filters.LinqFilter)

The LinqFilter class provides methods to filter information about games using LINQ.

Methods:

- `FilterAllTitles(List<Game> games)`: Filters and displays all distinct titles present in the list of games.
- `FilterGamePrice(List<Game> games, string title)`: Filters and displays the price of a specific game by title.
- `FilterGameRatingPercent(List<Game> games, string title)`: Filters and displays the rating percentage of a specific game by title.

### Class LinqOrder (cheap_shark.Filters.LinqOrder)

The LinqOrder class provides methods to order information about games using LINQ.

Methods:

- `ShowGamesOrderByTitle(List<Game> games)`: Orders and displays game titles in alphabetical order.
- `ShowGamesOrderByPrice(List<Game> games)`: Orders and displays games by price in descending order.
- `ShowGamesOrderByRatingPercent(List<Game> games)`: Orders and displays games by rating percentage in descending order.

## Conclusion

The Cheap Shark project has been a valuable learning experience, providing insights into key concepts in software development. Some of the main lessons learned during the development of this project include:

1. **API Integration**: Understanding how to effectively consume and interact with external APIs, such as the Cheap Shark API, to retrieve and process data for use in the application.
2. **Class Modeling**: Learning the importance of thoughtful class design to represent real-world entities, such as games, in a way that is both logical and maintainable.
3. **Data Parsing and Formatting**: Implementing robust methods for parsing and formatting data, such as converting string representations of prices and percentages into usable numeric formats.
4. **LINQ Queries**: Utilizing LINQ (Language-Integrated Query) for efficient and expressive querying and manipulation of collections, enabling features like filtering, sorting, and distinct operations.
5. **Modular Architecture**: Structuring the application with modular components, such as classes for filtering and ordering, to enhance code organization and maintainability.
6. **Exception Handling**: Implementing error handling mechanisms, such as try-catch blocks, to gracefully manage potential issues, ensuring a more robust and user-friendly application.
7. **File Operations**: Learning how to generate and work with files, such as creating JSON files to store user-specific data like favorite games.

1. In conclusion, the Cheap Shark project has provided a hands-on opportunity to apply these fundamental concepts in a practical setting, reinforcing a solid foundation in software development practices.

https://www.cheapshark.com/about