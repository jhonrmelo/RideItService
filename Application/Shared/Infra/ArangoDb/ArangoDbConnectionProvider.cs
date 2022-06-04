using ArangoDBNetStandard;

using System.Threading.Tasks;

namespace Application.Shared.Infra.ArangoDb
{
    public class ArangoDbConnectionProvider : IArangoDbConnectionProvider
    {
        private ArangoDBClient _arangoDBClient;

        public ArangoDbConnectionProvider(ArangoDBClient arangoDBClient)
        {
            _arangoDBClient = arangoDBClient;
        }

        public async Task<ArangoDBClient> GetArangoDBConnectionAsync()
        {
            return _arangoDBClient;
        }
    }
}