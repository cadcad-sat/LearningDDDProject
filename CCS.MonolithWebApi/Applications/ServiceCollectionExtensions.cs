using CCS.MonolithWebApi.Domains;
using CCS.MonolithWebApi.Domains.Entities;
using CCS.MonolithWebApi.Domains.Interfaces;
using CCS.MonolithWebApi.Infrastructures.BlobServices;
using CCS.MonolithWebApi.Persistences.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CCS.MonolithWebApi.Applications
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
