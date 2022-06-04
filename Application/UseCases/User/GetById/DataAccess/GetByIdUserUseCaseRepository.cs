using Application.Shared.Infra.SqlServer;

using Dapper;

using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetById.DataAccess
{
    public class GetByIdUserUseCaseRepository : IGetByIdUserUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public GetByIdUserUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task<UsersEntity> GetById(int id, CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);

            return await conn.QueryFirstOrDefaultAsync<UsersEntity>(GetByIdUserUseCaseCommands.GetByIdQuery, new { id });
        }
    }
}