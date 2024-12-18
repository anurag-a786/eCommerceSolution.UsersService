using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension method to add infrastructure services to the dependency injection container
        /// </summary>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // TO DO : Add services to the IoC container
            // Infrastructure components often include data access, caching and other low-level components.

            services.AddSingleton<IUsersRepository, UsersRepository>();

            return services;
        }
    }
}

