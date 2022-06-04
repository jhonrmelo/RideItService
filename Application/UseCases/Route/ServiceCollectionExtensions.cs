using Application.UseCases.Route.Get;
using Application.UseCases.Route.GetByUserId;
using Application.UseCases.Route.Insert;
using Application.UseCases.Route.UpdateRouteSegments;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Route
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRouteUseCases(this IServiceCollection services)
        {
            return services.AddGetRouteUseCase()
                           .AddInsertRouteUseCase()
                           .AddGetRouteByUserIdUseCase()
                           .AddUpdateRouteSegmentUseCase();
        }
    }
}