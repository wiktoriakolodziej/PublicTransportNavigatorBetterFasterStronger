using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("vehicle_type")]
    public class VehicleType
    {
        public long Id { get; set; }
        public required string Type { get; set; }
        public required ICollection<Vehicle> Vehicles { get; set; }
    }
}
