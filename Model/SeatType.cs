using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("seat_types")]
    public class SeatType
    {
        public long Id { get; set; }
        public required string Type { get; set; }
    }
}
