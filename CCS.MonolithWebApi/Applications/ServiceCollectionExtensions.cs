using System.Reflection;
using CCS.MonolithWebApi.Domains.Interfaces;
using CCS.MonolithWebApi.Infrastructures.BlobServices;
using CCS.MonolithWebApi.Persistences.DbContexts;
using MediatR;
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
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // Persistences
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AppDatabase")));
            services.AddScoped<IDbRepository, AppDbRepository>();

            // Infrastructures
            services.AddTransient<SampleContainer>();

            return services;
        }
    }
}
