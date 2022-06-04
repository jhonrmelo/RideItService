using Domain.Entity.Mongo;

using MongoDB.Driver;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Insert.DataAccess
{
    public class InsertRouteRepository : IInsertRouteRepository
    {
        private readonly IMongoCollection<RouteCollection> userRoutesCollection;

        public InsertRouteRepository(IMongoCollection<RouteCollection> userRoutesCollection)
        {
            this.userRoutesCollection = userRoutesCollection;
        }

        public async Task InsertAsync(RouteCollection collection, CancellationToken cancellationToken)
        {
            await userRoutesCollection.InsertOneAsync(collection);
        }
    }
}