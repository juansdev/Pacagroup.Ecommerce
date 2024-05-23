using Pacagroup.Ecommerce.CrossSectional.Common;
using Pacagroup.Ecommerce.CrossSectional.Logging;
using Pacagroup.Ecommerce.Services.WebApi.Modules.GlobalException;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<GlobalExceptionHandler>();

            return services;
        }
    }
}
