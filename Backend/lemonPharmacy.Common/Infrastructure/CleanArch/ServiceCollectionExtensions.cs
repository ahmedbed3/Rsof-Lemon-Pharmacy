using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace lemonPharmacy.Common.Infrastructure.AspNetCore.CleanArch
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCleanArch(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UnitOfWorkBehavior<,>));
            return services;
        }
    }
}
