using Ado.Net_learning.Models;
using Ado.Net_learning.Repositories;
namespace Ado.Net_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //var gameRepo = new GameRepository();
            //var games = gameRepo.GetGames();
            //DisplayGames(games);


            var tyreRepo = new TyreRepository();
            var tyre = tyreRepo.GetTyre();  
            DisplayTyre(tyre);
        }

        private static void DisplayGames(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine($"Game : {game.Id} - {game.Name} - {game.RankingType}");
            }
        }
        private static void DisplayTyre(List<Tyre> list)
        {
            foreach (var tyre in list) 
            {
                Console.WriteLine($"Tyre : {tyre.Id} - tyreSizeId : {tyre.TyreSizeId} - tyreConstructorId : {tyre.TyreConstructorId}");
            }
        }
    }
}
