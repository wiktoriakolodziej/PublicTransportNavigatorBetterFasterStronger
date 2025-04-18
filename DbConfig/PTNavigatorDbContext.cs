using Microsoft.EntityFrameworkCore;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class PTNavigatorDbContext(DbContextOptions<PTNavigatorDbContext> options) : DbContext(options)
    {
        public DbSet<VehicleType> LineTypes { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<SeatReservation> SeatReservations { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PTNavigatorDbContext).Assembly);
        }
    }
}
