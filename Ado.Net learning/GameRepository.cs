using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_learning
{
    public static class GameRepository
    {
        public static List<Game> GetGames()
        {
            var games = Dal.GetData("SELECT * FROM dbo.Exo2_Game", "Server=tcp:inoksch.database.windows.net,1433;Initial Catalog=mattis.dev;Persist Security Info=False;User ID=it;Password=2Thehouseistallandred!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            return games;
        }
        
    }
}
