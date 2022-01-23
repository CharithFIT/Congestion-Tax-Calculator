using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Repository.Lookup
{
    public static class LookupRepositoryInstaller
    {
        public static IServiceCollection InstallLookupRepositories(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration config)
        {
            services.AddTransient<ILookupRepository, LookupRepository>();
     
            return services;
        }
    }
}
