using GameStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.Infrastructure.Support
{
    public static class DependenciesRegisterExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAutoMapper(AutoMapperConfig.RegisterMappings());
            var sqlConnection = configuration.GetConnectionString("GameStore");
            services.AddDbContext<GameDbContext>(
                option => option.UseSqlServer(sqlConnection)
            );

            RegisterRepositories(services);

            return services;
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            //services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
