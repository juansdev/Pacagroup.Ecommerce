using Pacagroup.Ecommerce.CrossSectional.Mapper;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Mapper
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MapppingsProfile()));
            return services;
        }
    }
}
