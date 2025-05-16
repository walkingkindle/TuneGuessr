using Microsoft.Extensions.DependencyInjection;
using TuneGuessr.Application.Contracts.Persistence;
using TuneGuessr.Infrastructure.Repositories;

namespace TuneGuessr.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IPlayerRepository, PlayerRepository>();

            return services;

        }
        

    }
}
