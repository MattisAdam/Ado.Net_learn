﻿using Ado.Net_learning;

class Program
{
    static void Main(string[] args)
    {
        var games = GameRepository.GetGames();
        DisplayGames(games);
        //var games = Dal.Toto();
        //DisplayGames(games);
    }

    private static void DisplayGames(List<Game> games)
    {
        foreach (var game in games)
        {
            Console.WriteLine($"Game : {game.Id} - {game.Name} - {game.RankingType}");
        }
    }
}
