using MediaList.Data.Constants;
using MediaList.Data.Infrastructure;
using MediaList.Data.Interfaces;

namespace MediaList.Data.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediaListData (this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<MediaListDbContext>();
            services.AddSingleton<IGenreRepository, GenreRepository>();
            services.AddSingleton<IMediaTypeRepository, MediaTypeRepository>();
            services.AddSingleton<IMangaRepository, MangaRepository>();

            return services;
        }

        public static async Task<WebApplication?> CreateDatabaseIfNotExistsAsync(this WebApplication? app)
        {
            using var scope = app?.Services.CreateScope();
            var services = scope?.ServiceProvider;

            if (services == null) return app;

            var context = services.GetRequiredService<MediaListDbContext>();

            await Seed.DoSeedAsync(context);

            return app;
        }
    }
}
