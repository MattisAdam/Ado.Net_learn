using Ado.Net_learning.Base;
using Ado.Net_learning.Models;
using Ado.Net_learning.SqlDefinition;

namespace Ado.Net_learning.Repositories
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
