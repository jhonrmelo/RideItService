using Application.Shared.Infra.SqlServer;

using Dapper;

using Domain.Entity;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetAll.DataAccess
{
    public class GetAllUserUseCaseRepository : IGetAllUserUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public GetAllUserUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task<IEnumerable<UsersEntity>> GetAll(CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);

            return await conn.QueryAsync<UsersEntity>(GetAllUserUseCaseCommands.GetAll);
        }
    }
}