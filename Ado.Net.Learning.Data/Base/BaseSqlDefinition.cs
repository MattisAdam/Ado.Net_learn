using System.Data.SqlClient;

namespace Ado.Net.Learning.Data.Base
{
    public abstract class BaseSqlDefinition<T> where T : IModel
    {
        public abstract void SetSqlData(List<T> list, SqlDataReader reader);
    }
}