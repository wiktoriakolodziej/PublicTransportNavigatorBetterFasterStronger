using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class StopConfiguration : IEntityTypeConfiguration<Stop>
    {
        public void Configure(EntityTypeBuilder<Stop> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(s=>s.OnRequest).HasDefaultValue(false);
            builder.OwnsOne(s => s.Coordinate, coordinate =>
            {
                coordinate.Property(c => c.Latitude)
                    .IsRequired();
                coordinate.Property(c => c.Longitude)
                    .IsRequired();
            });
        }
    }
}
