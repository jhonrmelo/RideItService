using Domain.Entity.Mongo;

using MongoDB.Driver;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.UpdateRouteSegments.DataAccess
{
    public class UpdateRouteSegmentsRepository : IUpdateRouteSegmentsRepository
    {
        private readonly IMongoCollection<RouteCollection> userRoutesCollection;

        public UpdateRouteSegmentsRepository(IMongoCollection<RouteCollection> userRoutesCollection)
        {
            this.userRoutesCollection = userRoutesCollection;
        }

        public async Task<RouteCollection> GetUserRoute(Guid routeId, CancellationToken cancellationToken)
        {
            var resultCursor = await userRoutesCollection.FindAsync(filter => filter.Id == routeId);

            return await resultCursor.FirstOrDefaultAsync(cancellationToken);
        }

        public async Task Update(RouteCollection route, CancellationToken cancellationToken)
        {
            await userRoutesCollection.ReplaceOneAsync(filter => filter.Id == route.Id, route, new ReplaceOptions() { IsUpsert = true }, cancellationToken);
        }
    }
}