using Ado.Net_learning.Base;

namespace Ado.Net_learning.Models
{
    public class Tyre : IModel
    {
        public int Id { get; set; }
        public int TyreSizeId { get; set; }
        public int TyreConstructorId { get; set; }
        public Tyre(int id, int tyresizeid, int tyreconstructorid)
        {
            Id = id;
            TyreSizeId = tyresizeid;
            TyreConstructorId = tyreconstructorid;
        }
    }
}
