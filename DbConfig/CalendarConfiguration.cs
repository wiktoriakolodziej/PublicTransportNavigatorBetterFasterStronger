using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class CalendarConfiguration : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.Property(c => c.Monday)
                .HasDefaultValue(false);
            builder.Property(c => c.Tuesday)
                .HasDefaultValue(false);
            builder.Property(c => c.Wednesday)
                .HasDefaultValue(false);
            builder.Property(c => c.Thursday)
                .HasDefaultValue(false);
            builder.Property(c => c.Friday)
                .HasDefaultValue(false);
            builder.Property(c => c.Saturday)
                .HasDefaultValue(false);
            builder.Property(c => c.Sunday)
                .HasDefaultValue(false);
        }
    }
}
