using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("seat_reservations")]
    public class SeatReservation
    {
        public int Id { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public int TravelId { get; set; }
        public Travel? Travel { get; set; }
        public int? SeatId { get; set; }
        public Seat? Seat { get; set; }
    }
}
