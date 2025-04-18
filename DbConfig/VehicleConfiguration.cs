using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(v => v.WheelchairAccessible).HasDefaultValue(false);

            builder.HasOne(v => v.VehicleType)
                .WithMany()
                .HasForeignKey(v=> v.VehicleTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(v => v.Line)
                .WithMany(l => l.Vehicles)
                .HasForeignKey(v => v.LineId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
