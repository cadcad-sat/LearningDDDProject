using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CCS.Application.Domains
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            // Domains
            services.AddMediatR(Assembly.GetAssembly(typeof(ServiceCollectionExtensions)));

            return services;
        }
    }
}
