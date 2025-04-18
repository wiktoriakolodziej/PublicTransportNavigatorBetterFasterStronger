using System.ComponentModel.DataAnnotations.Schema;

namespace PublicTransportNavigatorv2.Model
{
    [Table("schedules")]
    public class Schedule
    {
        public long Id { get; set; }
        public required TimeOnly ArrivalTime { get; set; }
        public int LineId { get; set; }
        public Line? Line { get; set; }
        public int StopId { get; set; }
        public Stop? Stop { get; set; }
    }
}
