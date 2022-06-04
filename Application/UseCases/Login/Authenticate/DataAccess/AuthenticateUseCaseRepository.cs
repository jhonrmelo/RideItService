using Application.Shared.Infra.SqlServer;

using Dapper;

using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Authenticate.DataAccess
{
    public class AuthenticateUseCaseRepository : IAuthenticateUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public AuthenticateUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task<UsersEntity> GetUserByLoginAsync(string email, string password, CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);
            return await conn.QueryFirstOrDefaultAsync<UsersEntity>(GetUserByLoginCommand.Query, new { email, password });
        }
    }
}