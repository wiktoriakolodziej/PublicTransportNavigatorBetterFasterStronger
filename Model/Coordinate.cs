using Microsoft.EntityFrameworkCore;

namespace PublicTransportNavigatorv2.Model
{
    [Owned]
    public class Coordinate
    {
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
    }
}
