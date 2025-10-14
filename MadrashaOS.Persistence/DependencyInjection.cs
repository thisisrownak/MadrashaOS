using MadrashaOS.Application.Interfaces;
using MadrashaOS.Infrastructure.Persistence;
using MadrashaOS.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MadrashaOS.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // 1️⃣ Database Context
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // 2️⃣ Repository Registrations
        services.AddScoped<IProductRepository, ProductRepository>();

        

        return services;
    }
}
