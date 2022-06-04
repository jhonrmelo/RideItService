using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Shared.Infra.SqlServer
{
    public interface IConnectionProvider
    {
        Task<IDbConnection> GetConnectionAsync(CancellationToken cancellationToken);
    }
}