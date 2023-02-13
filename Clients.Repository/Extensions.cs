using Clients.Repository.Interfaces;
using Clients.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Clients.Repository
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IHmoRepository,HmoRepository>();
            return services;
        }
    }
}