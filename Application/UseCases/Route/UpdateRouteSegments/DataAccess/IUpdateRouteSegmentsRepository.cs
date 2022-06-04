using Domain.Entity.Mongo;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.UpdateRouteSegments.DataAccess
{
    public interface IUpdateRouteSegmentsRepository
    {
        Task<RouteCollection> GetUserRoute(Guid route, CancellationToken cancellationToken);

        Task Update(RouteCollection route, CancellationToken cancellationToken);
    }
}