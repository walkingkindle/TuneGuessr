using TuneGuessr.API;

var builder = WebApplication.CreateBuilder(args);

var app = StartupExtensions.ConfigureServices(builder);

StartupExtensions.ConfigurePipeline(app,builder.Environment);

app.Run();
