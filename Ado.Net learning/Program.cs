using Ado.Net_learning.Base;
using Ado.Net_learning.Models;
using Ado.Net_learning.Repositories;
using Ado.Net_learning.SqlDefinition;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Ado.Net_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameRepo = new GameRepository();
            var newGame = new Game("Valorant", true);
            var updateGame = new Game("Mikado", true);


            gameRepo.InsertGame(newGame);
            gameRepo.DeleteGame(newGame);
            gameRepo.UpdateGame(newGame, updateGame);
            gameRepo.DeleteGame(updateGame);

            var games = gameRepo.GetGames();
            DisplayGames(games);


            //var tyreRepo = new TyreRepository();
            //var tyre = tyreRepo.GetTyre();
            //var carRepo = new CarRepository();
            //var car = carRepo.GetCar();
            //DisplayTyre(tyre);
            //DisplayCar(car);

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
        private static void DisplayCar(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Car : {car.Id} - Model : {car.ModelCarId} - Color : {car.ColorCarId} - Tyre : {car.TyreId}");
            }
        }
    }
}
