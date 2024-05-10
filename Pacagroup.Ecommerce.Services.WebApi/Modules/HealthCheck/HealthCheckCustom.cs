using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.HealthCheck
{
    public class HealthCheckCustom : IHealthCheck
    {
        private readonly Random _random = new();
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var responseTime = _random.Next(1, 300);
            if(responseTime < 100)
            {
                return Task.FromResult(HealthCheckResult.Healthy("Healthy result form HealthCheckCustom"));
            } 
            else if(responseTime < 200)
            {
                return Task.FromResult(HealthCheckResult.Degraded("Degraded result form HealthCheckCustom"));
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Unhealthy result form HealthCheckCustom"));
            }
        }
    }
}
