using Microsoft.EntityFrameworkCore;
using PublicTransportNavigatorv2.DbConfig;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("vehicles")]
    [EntityTypeConfiguration(typeof(VehicleConfiguration))]
    public class Vehicle
    {
        public long Id { get; set; }
        public bool WheelchairAccessible { get; set; } = false;
        private long LineId { get; set; }
        public required Line Line { get; set; }
        private long VehicleTypeId { get; set; }
        public required VehicleType VehicleType { get; set; }
    }
}
