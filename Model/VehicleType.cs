using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("vehicle_types")]
    public class VehicleType
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Type { get; set; }
        //public required ICollection<Vehicle> Vehicles { get; set; }
    }
}
