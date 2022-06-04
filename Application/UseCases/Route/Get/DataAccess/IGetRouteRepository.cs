using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Get.DataAccess
{
    public interface IGetRouteRepository
    {
        Task<IEnumerable<RouteEntity>> ExecuteAsync(string from, string to, string preference);
    }
}