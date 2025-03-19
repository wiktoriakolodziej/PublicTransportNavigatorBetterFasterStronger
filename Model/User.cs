using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("users")]
    public class User
    {
        public long Id { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
    }
}
