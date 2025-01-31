using Ado.Net.Learning.Data.Base;
using Ado.Net.Learning.Data.Models;
using System.Data.SqlClient;

namespace Ado.Net.Learning.Data.SqlDefinition
{
    public class CarSqlDefinition : BaseSqlDefinition<Car>
    {
        public override void SetSqlData(List<Car> list, SqlDataReader reader)
        {
            var id = (int)reader["Id"];
            var MotorTypeId = (int)reader["MotorTypeId"];
            var ColorCarId = (int)reader["ColorCarId"];
            var ModelCarId = (int)reader["ModelCarId"];
            var TyreId = (int)reader["TyreId"];
            var tempCar = new Car(id, MotorTypeId, ColorCarId, ModelCarId, TyreId);
            list.Add(tempCar);
        }
    }
}
