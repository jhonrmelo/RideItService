using Application.UseCases.Route.Get.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Route.Get
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetRouteUseCase(this IServiceCollection services)
        {
            return services.AddSingleton<IGetRouteUseCase, GetRouteUseCase>()
                           .AddSingleton<IGetRouteRepository, GetRouteRepository>();
        }
    }
}