using TuneGuessr.Application;
using TuneGuessr.Infrastructure;
namespace TuneGuessr.API
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();

            builder.Services.AddInfrastructureServices();

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
