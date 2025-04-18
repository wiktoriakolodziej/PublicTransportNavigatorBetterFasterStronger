using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.Property(s => s.XOffset)
                .IsRequired();
            builder.Property(s => s.YOffset)
                .IsRequired();
            builder.HasOne(s => s.Vehicle)
                .WithMany(v => v.Seats)
                .HasForeignKey(s => s.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.SeatType)
                .WithMany()
                .HasForeignKey(s=>s.SeatTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
