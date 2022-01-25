using CongestionTaxCalculator.Service.Configuration;
using CongestionTaxCalculator.Service.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Service
{
    public static class ServiceInstaller
    {
        public static IServiceCollection InstallServices(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddServiceConfiguration(config)
                .InstallCalculatorService(config);

            return services;
        }
    }
}
