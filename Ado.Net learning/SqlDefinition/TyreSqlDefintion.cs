using Ado.Net_learning.Base;
using Ado.Net_learning.Models;
using System.Data.SqlClient;

namespace Ado.Net_learning.SqlDefinition
{
    public class TyreSqlDefintion : BaseSqlDefinition<Tyre>
    {
        public override void SetSqlData(List<Tyre> list, SqlDataReader reader)
        {
            var id = (int)reader["Id"];
            var tyreSizeId = (int)reader["TyreSizeId"];
            var tyreConstructorId = (int)reader["TyreConstructorId"];
            var tempTyre = new Tyre(id, tyreSizeId, tyreConstructorId);
            list.Add(tempTyre);
        }
    }
}
