using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class SchedulesConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.Property(s => s.ArrivalTime)
                .IsRequired();
            builder.HasOne(s => s.Line)
                .WithMany()
                .HasForeignKey(s => s.LineId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s=>s.Stop)
                .WithMany()
                .HasForeignKey(s=>s.StopId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
