using Ado.Net.Learning.Data.Base;
using Ado.Net.Learning.Data.Models;
using Ado.Net.Learning.Data.SqlDefinition;

namespace Ado.Net.Learning.Data.Repositories
{
    public class TyreRepository : BaseRepository
    {
        public List<Tyre> GetTyres()
        {
            var tyres = Dal.GetData<Tyre, TyreSqlDefintion>("SELECT * FROM [dbo].[Exo1_Tyre]", Connection);

            return tyres;
        }
    }
}
