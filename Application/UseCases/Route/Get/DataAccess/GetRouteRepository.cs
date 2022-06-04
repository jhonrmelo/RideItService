using Application.Shared.Infra.ArangoDb;

using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Get.DataAccess
{
    public class GetRouteRepository : IGetRouteRepository
    {
        private readonly IArangoDbConnectionProvider _arangoDbConnectionProvider;

        public GetRouteRepository(IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _arangoDbConnectionProvider = arangoDbConnectionProvider;
        }

        public async Task<IEnumerable<RouteEntity>> ExecuteAsync(string from, string to, string preference)
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            var @params = new Dictionary<string, object>() { { "from", from }, { "to", to }, { "preference", preference } };

            var response = await adb.Cursor.PostCursorAsync<RouteEntity>(GetRouteCommand.AqlQuery, @params);

            return response.Result;
        }
    }
}