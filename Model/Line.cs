using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("lines")]
    public class Line
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public required string Name { get; set; }
        public required ICollection<Vehicle> Vehicles { get; set;}
        public int CalendarId { get; set; }
        public Calendar? Calendar { get; set; }

    }
}
