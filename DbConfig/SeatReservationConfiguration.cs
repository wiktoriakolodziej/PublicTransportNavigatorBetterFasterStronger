using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class SeatReservationConfiguration : IEntityTypeConfiguration<SeatReservation>
    {
        public void Configure(EntityTypeBuilder<SeatReservation> builder)
        {
            builder.Property(sr => sr.StartTime)
                .IsRequired();
            builder.Property(sr => sr.EndTime)
                .IsRequired();
            builder.HasOne(sr => sr.Travel)
                .WithMany()
                .HasForeignKey(sr => sr.TravelId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(sr => sr.Seat)
                .WithMany()
                .HasForeignKey(sr => sr.SeatId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
