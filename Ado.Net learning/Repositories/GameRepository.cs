using Ado.Net_learning.Base;
using Ado.Net_learning.Models;
using Ado.Net_learning.SqlDefinition;

namespace Ado.Net_learning.Repositories
{
    public class GameRepository : BaseRepository
    {
        public List<Game> GetGames()
        {
            var games = Dal.GetData<Game, GameSqlDefinition>("SELECT * FROM dbo.Exo2_Game", Connection);

            return games;
        }

        public void InsertGame(Game game)
        {
            var x = new GameSqlDefinition();
            var query = x.GetInsertCommand(game);
            Dal.ExecuteSql(Connection, game, query);
        }
        public void DeleteGame(Game game)
        {
            var x = new GameSqlDefinition();
            var query = x.GetDeleteCommand(game);
            Dal.ExecuteSql(Connection, game, query);
        }
        public void UpdateGame(Game game, Game updateGame)
        {
            var x = new GameSqlDefinition();
            var query = x.GetUpdateCommand(game, updateGame);
            Dal.ExecuteSql(Connection, game, query);
        }

    }
}