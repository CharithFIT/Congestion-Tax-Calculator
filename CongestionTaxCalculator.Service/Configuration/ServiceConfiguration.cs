using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Service.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<SingleChargeRuleConfiguration>(config.GetSection("SingleChargeRule"));
            services.Configure<CongestionTaxRuleConfiguration>(config.GetSection("CongestionTaxRule"));

            return services;
        }
    }
}
