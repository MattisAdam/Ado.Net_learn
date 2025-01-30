using Ado.Net_learning.Base;

namespace Ado.Net_learning.Models
{
    public class Car : IModel
    {
        public int Id { get; set; }
        public int MotorTypeId { get; set; }
        public int ColorCarId { get; set; }
        public int ModelCarId { get; set; }
        public int TyreId { get; set; }
        public Car(int id, int motorType, int colorCarId, int modelCarId, int tyreId )
        {
            Id = id;
            MotorTypeId = motorType;
            ColorCarId = colorCarId;
            ModelCarId = modelCarId;
            TyreId = tyreId;
        }
    }
}
