using System.Text.Json.Serialization;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Feature
{
    public static class FeatureExtensions
    {
        static readonly string myPolicy = "policyApiEcommerce";
        public static IServiceCollection AddFeature(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options => options.AddPolicy(myPolicy,
                builder => builder.WithOrigins(configuration["Config:OriginCors"])
                                  .AllowAnyHeader()
                                  .AllowAnyMethod()
            ));
            services.AddEndpointsApiExplorer();
            services.AddControllers()
                    .AddJsonOptions(options =>
                    {
                        var enumConverter = new JsonStringEnumConverter();
                        options.JsonSerializerOptions.Converters.Add(enumConverter);
                    });
            return services;
        }
    }
}
