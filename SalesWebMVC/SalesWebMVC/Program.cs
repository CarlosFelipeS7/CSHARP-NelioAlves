using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

// NÃO registrar o SeedingService aqui se já foi registrado no Startup.
// builder.Services.AddTransient<SeedingService>();

var app = builder.Build();
startup.Configure(app);

// obter logger para diagnosticar
var logger = app.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("Iniciando sequence de migrations e seeding...");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<SalesWebMVCContext>();
        logger.LogInformation("Aplicando migrations (Database.Migrate)...");
        context.Database.Migrate();

        var seeder = services.GetRequiredService<SeedingService>();
        logger.LogInformation("Executando SeedingService...");
        seeder.Seed();

        logger.LogInformation("Migrations e seeding concluídos.");
    }
    catch (Exception ex)
    {
        var loggerScope = services.GetRequiredService<ILogger<Program>>();
        loggerScope.LogError(ex, "Erro ao aplicar migrations ou executar SeedingService.");
        throw;
    }
}

// registrar as URLs efetivas no host antes de rodar
try
{
    var urls = app.Urls != null && app.Urls.Any()
        ? string.Join(";", app.Urls)
        : Environment.GetEnvironmentVariable("ASPNETCORE_URLS") ?? "nenhuma URL configurada";
    logger.LogInformation("Host pronto. URLs: {Urls}", urls);

    app.Run();
}
catch (Exception ex)
{
    logger.LogError(ex, "Host falhou ao iniciar.");
    throw;
}

        