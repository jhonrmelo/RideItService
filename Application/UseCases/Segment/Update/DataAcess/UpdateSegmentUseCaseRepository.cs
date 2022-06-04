using Application.Shared.Infra.ArangoDb;
using Application.UseCases.Update.Update.DataAcess;

using Domain.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.Update.DataAcess
{
    public class UpdateSegmentUseCaseRepository : IUpdateSegmentUseCaseRepository
    {
        private readonly IArangoDbConnectionProvider _arangoDbConnectionProvider;

        public UpdateSegmentUseCaseRepository(IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _arangoDbConnectionProvider = arangoDbConnectionProvider;
        }

        public async Task Update(IEnumerable<SegmentEntity> segment)
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            await adb.Document.PutDocumentsAsync("Segment", segment.ToList());
        }

        public async Task<IEnumerable<SegmentEntity>> GetById(IEnumerable<string> ids)
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            var aqlQuery = $@"for seg in Segment filter seg._id in [{BuildIdsFilter(ids)}] return seg";

            var response = await adb.Cursor.PostCursorAsync<SegmentEntity>(aqlQuery);

            return response.Result;
        }

        private string BuildIdsFilter(IEnumerable<string> ids) => string.Join(",", ids.Select(id => $"'{id}'"));
    }
}