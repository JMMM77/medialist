using MediaList.Services.Interfaces;
using MediaList.Services.Mappings;
using MediaList.Services.Services;

namespace MediaList.Services.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediaListServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MangaProfile));
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IMangaService, MangaService>();

            return services;
        }
    }
}
