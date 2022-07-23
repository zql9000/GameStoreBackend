using GameStore.Application.Services;
using GameStore.Application.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.Application.Support
{
    public static class DependencyRegisterExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(AutoMapperConfig.RegisterMappings());

            RegisterServices(services);
            return services;
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IGenreService, GenreService>();
        }
    }
}
