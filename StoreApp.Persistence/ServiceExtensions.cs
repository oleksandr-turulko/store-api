using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreApp.Application.Repository.Clients;
using StoreApp.Persistence.Context;
using StoreApp.Persistence.Repository.Clients;

namespace StoreApp.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString("MSSQl");
        services.AddDbContext<StoreAppDbContext>(options =>
            options.UseSqlServer(connection));

        services.AddScoped<IClientsRepository, ClientsRepository>();
    }
}