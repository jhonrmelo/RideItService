using Domain.Entity.Mongo;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Insert.DataAccess
{
    public interface IInsertRouteRepository
    {
        Task InsertAsync(RouteCollection collection, CancellationToken cancellationToken);
    }
}