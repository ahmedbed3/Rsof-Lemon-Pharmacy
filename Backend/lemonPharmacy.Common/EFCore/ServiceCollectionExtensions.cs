using lemonPharmacy.Common.Domain;
using Microsoft.Extensions.DependencyInjection;
using lemonPharmacy.Common.Infrastructure.EfCore.Db;

namespace lemonPharmacy.Common.Infrastructure.EfCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGenericRepository(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWorkAsync, UnitOfWork>();
            services.AddScoped<IQueryRepositoryFactory, QueryRepositoryFactory>();
            return services;
        }

        public static IServiceCollection AddInMemoryDb(this IServiceCollection services)
        {
            services.AddScoped<IDbConnStringFactory, NoOpDbConnStringFactory>();
            return services;
        }

    }

    internal class NoOpDbConnStringFactory : IDbConnStringFactory
    {
        public string Create()
        {
            return string.Empty;
        }
    }

}
