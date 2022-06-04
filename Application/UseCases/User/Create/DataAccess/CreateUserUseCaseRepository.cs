using Application.Shared.Infra.SqlServer;

using Dapper;
using Dapper.Contrib.Extensions;

using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Create.DataAccess
{
    public class CreateUserUseCaseRepository : ICreateUserUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public CreateUserUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task Create(UsersEntity user, CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);
            await conn.InsertAsync(user);
        }

        public async Task<UsersEntity> GetByEmail(string email, CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);

            return await conn.QueryFirstOrDefaultAsync<UsersEntity>(CreateUserUseCaseCommands.GetByEmailQuery, new { email });
        }
    }
}