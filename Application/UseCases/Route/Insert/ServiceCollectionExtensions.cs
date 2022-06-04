using Application.UseCases.Route.Insert.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Route.Insert
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInsertRouteUseCase(this IServiceCollection services)
        {
            return services.AddSingleton<IInsertRouteUseCase, InsertRouteUseCase>()
                           .AddSingleton<IInsertRouteRepository, InsertRouteRepository>();
        }
    }
}