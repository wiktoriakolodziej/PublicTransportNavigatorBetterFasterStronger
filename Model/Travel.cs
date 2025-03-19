namespace PublicTransportNavigatorv2.Model
{
    public class Travel
    {
        public long Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}