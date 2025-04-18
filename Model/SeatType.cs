using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("seat_types")]
    public class SeatType
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Type { get; set; }
    }
}
