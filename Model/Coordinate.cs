using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("coordinates")]
    public class Coordinate
    {
        public long Id { get; set; }
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
    }
}
