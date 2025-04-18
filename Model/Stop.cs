using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("stops")]
    public class Stop
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public required string Name { get; set; }
        public bool OnRequest { get; set; } = false;
        public required Coordinate Coordinate { get; set; }
    }
}
