using Application.Shared.Infra.SqlServer;

using Dapper.Contrib.Extensions;

using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Update.DataAccess
{
    public class UpdateUserUseCaseRepository : IUpdateUserUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public UpdateUserUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task Update(UsersEntity user, CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);
            await conn.UpdateAsync(user);
        }
    }
}