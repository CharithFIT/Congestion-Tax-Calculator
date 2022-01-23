using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Service.Service
{
    public static class CalculatorServiceInstaller
    {
        public static IServiceCollection InstallCalculatorService(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration config)
        {
            services.AddTransient<ICalculatorService, CalculatorService>();

            return services;
        }
    }
}
