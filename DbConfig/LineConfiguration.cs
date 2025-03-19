using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class LineConfiguration : IEntityTypeConfiguration<Line>
    {
        public void Configure(EntityTypeBuilder<Line> builder)
        {
            builder.Property(e => e.Name).IsRequired();

            builder.HasMany(l => l.Vehicles)
                .WithOne(v => v.Line)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(l => l.Calendar)
                .WithMany(c => c.Lines)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
