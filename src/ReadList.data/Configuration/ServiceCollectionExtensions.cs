using ReadList.Data.Infrastructure;
using ReadList.Data.Interfaces;

namespace ReadList.Data.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddReadListData (this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<ReadListDbContext>();
            services.AddSingleton<IMangaRepository, MangaRepository>();

            return services;
        }

        public static async Task<WebApplication?> CreateDatabaseIfNotExistsAsync(this WebApplication? app)
        {
            using var scope = app?.Services.CreateScope();
            var services = scope?.ServiceProvider;

            if (services == null) return app;

            var context = services.GetRequiredService<ReadListDbContext>();

            await Seed.DoSeedAsync(context);

            return app;
        }
    }
}
