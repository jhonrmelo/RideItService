using Application.UseCases.Route.UpdateRouteSegments.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Route.UpdateRouteSegments
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUpdateRouteSegmentUseCase(this IServiceCollection services)
        {
            return services.AddSingleton<IUpdateRouteSegmentsRepository, UpdateRouteSegmentsRepository>()
                           .AddSingleton<IUpdateRouteSegmentsUseCase, UpdateRouteSegmentsUseCase>();
        }
    }
}