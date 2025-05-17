using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TuneGuessr.Application.Contracts.Auth;
using TuneGuessr.Application.Contracts.Persistence;
using TuneGuessr.Infrastructure.Auth;
using TuneGuessr.Infrastructure.Models.Auth;
using TuneGuessr.Infrastructure.Repositories;

namespace TuneGuessr.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IPlayerRepository, PlayerRepository>();

            services.AddTransient<ISpotifyAuthService, SpotifyAuthService>();

            return services;

        }
        

    }
}
