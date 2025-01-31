using Ado.Net.Learning.Data.Base;
using Ado.Net.Learning.Data.Models;
using Ado.Net.Learning.Data.SqlDefinition;

namespace Ado.Net.Learning.Data.Repositories
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
            Dal.ExecuteSql(Connection, query);
        }
        public void DeleteGame(Game game)
        {
            var x = new GameSqlDefinition();
            var query = x.GetDeleteCommand(game);
            Dal.ExecuteSql(Connection, query);
        }
        public void UpdateGame(Game game, Game updateGame)
        {
            var x = new GameSqlDefinition();
            var query = x.GetUpdateCommand(game, updateGame);
            Dal.ExecuteSql(Connection, query);
        }

    }
}