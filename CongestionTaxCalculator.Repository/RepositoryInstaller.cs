using CongestionTaxCalculator.Repository.Lookup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Repository
{
    public static class RepositoryInstaller
    {
        public static IServiceCollection InstallRepository(this IServiceCollection services, IConfiguration config)
        {
            services.AddConfig(config)
                .InstallLookupRepositories(config);

            return services;
        }
    }
}
