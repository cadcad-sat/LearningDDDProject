using CCS.Application.Domains;
using CCS.Application.Domains.Entities;
using CCS.Application.Domains.Interfaces;
using CCS.Application.Infrastructures.BlobServices;
using CCS.Application.Persistences.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CCS.Application.Applications
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Applications
            services.AddTransient<SampleService>();
            services.AddTransient<WeatherForecastService>();

            // Domains
            services.AddDomainServices();

            // Persistences
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AppDatabase")));
            services.AddScoped<IDbRepository, AppDbRepository>();

            // Infrastructures
            services.AddTransient<IBlobContainer<Sample>, SampleContainer>();

            return services;
        }
    }
}
