using Domain.Entity.Mongo;

using MongoDB.Driver;

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.GetByUserId.DataAccess
{
    public class GetRouteByUserIdRepository : IGetRouteByUserIdRepository
    {
        private readonly IMongoCollection<RouteCollection> userRoutesCollection;

        public GetRouteByUserIdRepository(IMongoCollection<RouteCollection> userRoutesCollection)
        {
            this.userRoutesCollection = userRoutesCollection;
        }

        public async Task<IEnumerable<RouteCollection>> GetUserRoutesAsync(int userId, CancellationToken cancellationToken)
        {
            var resultCursor = await userRoutesCollection.FindAsync(filter => filter.UserId == userId);

            return await resultCursor.ToListAsync(cancellationToken);
        }
    }
}