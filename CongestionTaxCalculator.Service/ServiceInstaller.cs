using CongestionTaxCalculator.Repository;
using CongestionTaxCalculator.Service.Configuration;
using CongestionTaxCalculator.Service.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Service
{
    public static class ServiceInstaller
    {
        public static IServiceCollection InstallService(this IServiceCollection services, IConfiguration config)
        {
            services
                .InstallRepository(config)
                .AddServiceConfig(config)
                .InstallCalculatorService(config);

            return services;
        }
    }
}
