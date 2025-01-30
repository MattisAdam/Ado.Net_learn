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
            Dal.InsertData(Connection, game);
        }

    }
}