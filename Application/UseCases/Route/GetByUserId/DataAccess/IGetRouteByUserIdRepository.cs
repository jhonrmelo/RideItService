using Domain.Entity.Mongo;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.GetByUserId.DataAccess
{
    public interface IGetRouteByUserIdRepository
    {
        Task<IEnumerable<RouteCollection>> GetUserRoutesAsync(int userId, CancellationToken cancellationToken);
    }
}