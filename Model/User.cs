using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Login { get; set; }
        [MaxLength(50)]
        public required string Password { get; set; }
        public IEnumerable<Travel>? Travels { get; set; }
    }
}
