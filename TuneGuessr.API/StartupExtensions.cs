using TuneGuessr.Application;
using TuneGuessr.Application.Contracts.Auth;
using TuneGuessr.Infrastructure;
using TuneGuessr.Infrastructure.Auth;
using TuneGuessr.Infrastructure.Models.Auth;
namespace TuneGuessr.API
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();

            builder.Services.AddInfrastructureServices();

            builder.Services.AddHttpClient<ISpotifyAuthService, SpotifyAuthService>(client =>
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                
            });


            builder.Services.Configure<SpotifyCredentials>(builder.Configuration.GetSection("SpotifyCredentials"));

            builder.Services.AddControllers();

            return builder.Build();

        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.MapControllers();

            return app;
        }
    }
}
