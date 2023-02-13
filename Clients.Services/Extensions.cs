using Clients.Repository;
using Clients.Services.Interfaces;
using Clients.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Clients.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IHmoService, HmoService>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}