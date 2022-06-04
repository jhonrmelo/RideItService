using ArangoDBNetStandard;

using System.Threading.Tasks;

namespace Application.Shared.Infra.ArangoDb
{
    public interface IArangoDbConnectionProvider
    {
        Task<ArangoDBClient> GetArangoDBConnectionAsync();
    }
}