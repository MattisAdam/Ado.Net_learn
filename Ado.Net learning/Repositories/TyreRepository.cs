using Ado.Net_learning.Base;
using Ado.Net_learning.Models;
using Ado.Net_learning.SqlDefinition;

namespace Ado.Net_learning.Repositories
{
    public class TyreRepository : BaseRepository
    {
        public List<Tyre> GetTyre()
        {
            var tyre = Dal.GetData<Tyre, TyreSqlDefintion>("SELECT * FROM [dbo].[Exo1_Tyre]", Connection);

            return tyre;
        }
    }
}
