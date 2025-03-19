namespace PublicTransportNavigatorv2.Model
{
    public class Stop
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public bool OnRequest { get; set; } = false;
    }
}
