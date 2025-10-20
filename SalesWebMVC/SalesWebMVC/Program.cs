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

// executar migrations e seeding dentro de um scope (resolve DbContext corretamente)
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<SalesWebMVCContext>();
        // aplica migrations pendentes (garante que o banco esteja atualizado)
        context.Database.Migrate();

        var seeder = services.GetRequiredService<SeedingService>();
        seeder.Seed();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Erro ao aplicar migrations ou executar SeedingService.");
        throw;
    }
}

app.Run();
