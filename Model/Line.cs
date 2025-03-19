using Microsoft.EntityFrameworkCore;
using PublicTransportNavigatorv2.DbConfig;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("lines")]
    [EntityTypeConfiguration(typeof(LineConfiguration))]
    public class Line
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required ICollection<Vehicle> Vehicles { get; set;}
        private long CalendarId { get; set; }
        public required Calendar Calendar { get; set; }

    }
}
