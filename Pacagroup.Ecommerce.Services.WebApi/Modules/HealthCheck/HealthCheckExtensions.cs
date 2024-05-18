﻿namespace Pacagroup.Ecommerce.Services.WebApi.Modules.HealthCheck
{
    public static class HealthCheckExtensions
    {
        public static IServiceCollection AddHealthCheck(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddSqlServer(configuration.GetConnectionString("NorthwindConnection"), tags: new[] { "database" })
                .AddCheck<HealthCheckCustom>("HealthCheckCustom", tags: new[] { "custom" });
            services.AddHealthChecksUI(settings =>
            {
                settings.AddHealthCheckEndpoint("Pacagroup.Ecommerce Health Status", configuration["Config:ApiHost"]+"/health-status");
            }).AddInMemoryStorage();
            return services;
        }
    }
}
