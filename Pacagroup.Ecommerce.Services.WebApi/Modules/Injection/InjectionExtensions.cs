using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Application.Interface.UseCases;
using Pacagroup.Ecommerce.Application.UseCases;
using Pacagroup.Ecommerce.CrossSectional.Common;
using Pacagroup.Ecommerce.CrossSectional.Logging;
using Pacagroup.Ecommerce.Persistence.Data;
using Pacagroup.Ecommerce.Persistence.Repository;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddSingleton<DapperContext>();
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IUsersApplication, UsersApplication>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoriesApplication, CategoriesApplication>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();

            return services;
        }
    }
}
