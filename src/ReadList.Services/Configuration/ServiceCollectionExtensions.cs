using ReadList.Services.Interfaces;
using ReadList.Services.Mappings;
using ReadList.Services.Services;

namespace ReadList.Services.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddReadListServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MangaProfile));
            services.AddScoped<IMangaService, MangaService>();

            return services;
        }
    }
}
