using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PublicTransportNavigatorv2.Model;

namespace PublicTransportNavigatorv2.DbConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u=>u.Login)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u=>u.Password)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
