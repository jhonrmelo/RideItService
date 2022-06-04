using Application.Shared.Infra.SqlServer;

using Dapper;

using Domain.Entity;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageDownload.DataAccess
{
    public class UserImageDownloadUseCaseRepository : IUserImageDownloadUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public UserImageDownloadUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task<UserProfileImageEntity> GetByUserIdAsync(int userId, CancellationToken cancellationToken)
        {
            var conn = await _connectionProvider.GetConnectionAsync(cancellationToken);

            return (await conn.QueryAsync<UserProfileImageEntity>(UserImageDownloadUseCaseCommands.GetByUserIdQuery, new { userId })).FirstOrDefault();
        }
    }
}