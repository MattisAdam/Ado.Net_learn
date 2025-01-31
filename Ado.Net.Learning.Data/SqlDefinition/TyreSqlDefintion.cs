using Ado.Net.Learning.Data.Base;
using Ado.Net.Learning.Data.Models;
using System.Data.SqlClient;

namespace Ado.Net.Learning.Data.SqlDefinition
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
