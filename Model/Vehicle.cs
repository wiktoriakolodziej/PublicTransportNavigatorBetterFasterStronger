using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }
        public bool WheelchairAccessible { get; set; } = false;
        public int? LineId { get; set; }
        public Line? Line { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType? VehicleType { get; set; }
        public ICollection<Seat>? Seats { get; set; }
    }
}
