using MonolithWebApi.Domains;
using MonolithWebApi.Domains.Entities;
using MonolithWebApi.Domains.Interfaces;
using MonolithWebApi.Infrastructures.BlobServices;
using MonolithWebApi.Persistences.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MonolithWebApi.Applications
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
