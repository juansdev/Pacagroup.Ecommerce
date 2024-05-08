using Microsoft.Extensions.Configuration;
using Pacagroup.Ecommerce.Application.Interface;
using Pacagroup.Ecommerce.Application.Main;
using Pacagroup.Ecommerce.CrossSectional.Common;
using Pacagroup.Ecommerce.Domain.Core;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infrastructure.Interface;
using Pacagroup.Ecommerce.Infrastructure.Repository;
using Pacagroup.Ecommerce.Infrastruture.Data;
using Pacagroup.Ecommerce.Transversal.Logging;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<ICustomersDomain, CustomersDomain>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IUsersApplication, UsersApplication>();
            services.AddScoped<IUsersDomain, UsersDomain>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            return services;
        }
    }
}
