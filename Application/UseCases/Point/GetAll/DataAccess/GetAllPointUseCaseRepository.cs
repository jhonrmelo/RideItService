using Application.Shared.Infra.ArangoDb;

using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetAll.DataAcess
{
    public class GetAllPointUseCaseRepository : IGetAllPointUseCaseRepository
    {
        private readonly IArangoDbConnectionProvider _arangoDbConnectionProvider;

        public GetAllPointUseCaseRepository(IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _arangoDbConnectionProvider = arangoDbConnectionProvider;
        }

        public async Task<IEnumerable<PointEntity>> GetAll()
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            string aqlQuery = @"FOR p in POI
                                RETURN p";

            var response = await adb.Cursor.PostCursorAsync<PointEntity>(aqlQuery);

            return response.Result;
        }
    }
}