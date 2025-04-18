using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class LineConfiguration : IEntityTypeConfiguration<Line>
    {
        public void Configure(EntityTypeBuilder<Line> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasOne(l => l.Calendar)
                .WithMany()
                .HasForeignKey(l=>l.CalendarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
