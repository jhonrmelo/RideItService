using Application.Shared.Infra.ArangoDb;

using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetAll.DataAcess
{
    public class GetAllSegmentUseCaseRepository : IGetAllSegmentUseCaseRepository
    {
        private readonly IArangoDbConnectionProvider _arangoDbConnectionProvider;

        public GetAllSegmentUseCaseRepository(IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _arangoDbConnectionProvider = arangoDbConnectionProvider;
        }

        public async Task<IEnumerable<SegmentEntity>> GetAll()
        {
            var adb = await _arangoDbConnectionProvider.GetArangoDBConnectionAsync();

            string aqlQuery = @"FOR s in Segment
                                RETURN s";

            var response = await adb.Cursor.PostCursorAsync<SegmentEntity>(aqlQuery);

            return response.Result;
        }
    }
}