using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("calendars")]
    public class Calendar
    {
        public int Id { get; set; }
        public bool Monday { get; set; } = false;
        public bool Tuesday { get; set; } = false;
        public bool Wednesday { get; set; } = false;
        public bool Thursday { get; set; } = false;
        public bool Friday { get; set; } = false;
        public bool Saturday { get; set; } = false;
        public bool Sunday { get; set; } = false;
    }
}
