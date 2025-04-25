using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString("MSQl");
        services.AddDbContext<StoreAppDbContext>(options =>
            options.UseSqlServer(connection));
    }
}