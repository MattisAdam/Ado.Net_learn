using Ado.Net_learning.Base;
using System.Data.SqlClient;

namespace Ado.Net_learning
{
    public class TyreSqlDefintion : BaseSqlDefinition <Tyre>
    {
        public override void SetSqlData(List<Tyre> list, SqlDataReader reader)
        {
            var id = (int)reader["Id"];
            var TyreSizeId = (int)reader["TyreSizeId"];
            var TyreConstructorId = (int)reader["TyreConstructorId"];
            var tempTyre = new Tyre(id, TyreSizeId, TyreConstructorId);
            list.Add(tempTyre);
        }
    }
}
