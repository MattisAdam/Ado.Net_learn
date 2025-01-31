using Ado.Net_learning.Base;
using Ado.Net_learning.Models;
using System.Data.SqlClient;

namespace Ado.Net_learning.SqlDefinition
{
    public class GameSqlDefinition : BaseSqlDefinition<Game>
    {
        public override void SetSqlData(List<Game> list, SqlDataReader reader)
        {
            var id = (int)reader["Id"];
            var name = (string)reader["Name"];
            var rankingType = (bool)reader["RankingType"];
            var tempGame = new Game(id, name, rankingType);
            list.Add(tempGame);
        }

        public string GetInsertCommand(Game game)
        {
            return $"INSERT INTO [dbo].[Exo2_Game] (Name, RankingType) VALUES ('{game.Name}', {(game.RankingType ? "1" : "0")});";
        }

        public string GetUpdateCommand(Game game, Game updateGame)
        {
            return $"UPDATE [dbo].[Exo2_Game] SET Name = '{updateGame.Name}' WHERE Name = '{game.Name}'";
        }
        public string GetDeleteCommand(Game game)
        {
            return $"DELETE FROM [dbo].[Exo2_Game] WHERE Name = '{game.Name}';";
        }
    }
}