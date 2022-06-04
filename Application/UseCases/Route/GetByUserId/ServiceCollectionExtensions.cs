using Application.UseCases.Route.GetByUserId.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Route.GetByUserId
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetRouteByUserIdUseCase(this IServiceCollection services)
        {
            return services.AddSingleton<IGetRouteByUserIdRepository, GetRouteByUserIdRepository>()
                           .AddSingleton<IGetRouteByUserIdUseCase, GetRouteByUserIdUseCase>();
        }
    }
}