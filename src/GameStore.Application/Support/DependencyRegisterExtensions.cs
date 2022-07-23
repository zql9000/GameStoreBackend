using Microsoft.Extensions.DependencyInjection;

namespace GameStore.Application.Support
{
    public static class DependencyRegisterExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            RegisterServices(services);
            return services;
        }

        private static void RegisterServices(IServiceCollection services)
        {
            //services.AddTransient<IEnvironmentService, EnvironmentService>();
        }
    }
}
