using Application.Shared.Infra.ArangoDb;

using Domain.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetById.DataAcess
{
    public class GetByIdPointUseCaseRepository : IGetByIdPointUseCaseRepository
    {
        private readonly IArangoDbConnectionProvider _arangoDbConnectionProvider;

        public GetByIdPointUseCaseRepository(IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _arangoDbConnectionProvider = arangoDbConnectionProvider;
        }

        public async Task<PointEntity> GetById(string id)
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            var @params = new Dictionary<string, object>() { { "id", id } };

            var response = await adb.Cursor.PostCursorAsync<PointEntity>("return document (@id)", @params);

            return response.Result.FirstOrDefault();
        }
    }
}