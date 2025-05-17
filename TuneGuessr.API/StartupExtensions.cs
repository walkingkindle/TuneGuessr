using Microsoft.OpenApi.Models;
using System.Reflection;
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

            builder.Services.AddInfrastructureServices(builder.Configuration);

            builder.Services.AddHttpClient<ISpotifyAuthService, SpotifyAuthService>();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TuneGuessr API", Version = "v1" });
            });

            builder.Services.Configure<SpotifyCredentials>(builder.Configuration.GetSection("SpotifyCredentials"));

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            return builder.Build();

        }

        public static WebApplication ConfigurePipeline(this WebApplication app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.MapControllers();
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }
            return app;
        }
    }
}
