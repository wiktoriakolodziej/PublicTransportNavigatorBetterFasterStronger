using Microsoft.EntityFrameworkCore;
using PublicTransportNavigatorv2.DbConfig;

namespace PublicTransportNavigatorv2
{
    public static class BuilderExtension
    {
        private static string DefaultConnection = "DefaultConnection";
        public static void RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            var connectionString =
                builder.Configuration.GetConnectionString(DefaultConnection)
                    ?? throw new InvalidOperationException($"Connection string {DefaultConnection} not found.");

            builder.Services.AddDbContext<PTNavigatorDbContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
