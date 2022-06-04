using Application.Shared.Infra.ArangoDb;

using Domain.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetById.DataAcess
{
    public class GetByIdSegmentUseCaseRepository : IGetByIdSegmentUseCaseRepository
    {
        private readonly IArangoDbConnectionProvider _arangoDbConnectionProvider;

        public GetByIdSegmentUseCaseRepository(IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _arangoDbConnectionProvider = arangoDbConnectionProvider;
        }

        public async Task<SegmentEntity> GetById(string id)
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            var @params = new Dictionary<string, object>() { { "id", id } };

            var response = await adb.Cursor.PostCursorAsync<SegmentEntity>("return document (@id)", @params);

            return response.Result.FirstOrDefault();
        }
    }
}