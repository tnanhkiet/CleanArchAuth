using CleanArchAuth.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchAuth.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("CleanArchAuth"));
        });

        return services;
    }
}
