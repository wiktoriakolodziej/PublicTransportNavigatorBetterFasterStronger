using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("seats")]
    public class Seat
    {
        public int Id { get; set; }
        public double XOffset { get; set; }
        public double YOffset { get; set; }
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }
        public int SeatTypeId { get; set; }
        public SeatType? SeatType { get; set; }
    }
}
