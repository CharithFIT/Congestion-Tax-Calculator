using CongestionTaxCalculator.Repository.Lookup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Repository
{
    public static class RepositoryInstaller
    {
        public static IServiceCollection InstallRepositories(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbConfiguration(config)
                .InstallLookupRepository(config);

            return services;
        }
    }
}
