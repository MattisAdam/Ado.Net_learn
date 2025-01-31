using Ado.Net.Learning.Data.Base;
using Ado.Net.Learning.Data.Models;
using Ado.Net.Learning.Data.SqlDefinition;

namespace Ado.Net.Learning.Data.Repositories
{
    public class CarRepository : BaseRepository
    {
        public List<Car> GetCars() 
        {
            var cars = Dal.GetData<Car, CarSqlDefinition>("SELECT * FROM [dbo].[Exo1_Car]", Connection);

            return cars;
        }
    }
}
