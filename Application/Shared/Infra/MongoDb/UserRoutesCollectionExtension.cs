using Domain.Entity.Mongo;

using Microsoft.Extensions.DependencyInjection;

using MongoDB.Driver;

namespace Application.Shared.Infra.MongoDb
{
    public static class UserRoutesCollectionExtension
    {
        public static IServiceCollection AddUserRouteCollection(this IServiceCollection services)
        {
            return services.AddSingleton(sp =>
            {
                var database = sp.GetRequiredService<IMongoDatabase>();

                return database.GetCollection<RouteCollection>(nameof(RouteCollection));
            });
        }
    }
}