using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class TravelConfiguration : IEntityTypeConfiguration<Travel>
    {
        public void Configure(EntityTypeBuilder<Travel> builder)
        {
            builder.Property(t=>t.StartTime)
                .IsRequired();
            builder.HasOne(t => t.User)
                .WithMany(u => u.Travels)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
