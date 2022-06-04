using Application.Shared.Infra.SqlServer;

using Dapper;
using Dapper.Contrib.Extensions;

using Domain.Entity;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageUpload.DataAccess
{
    public class UserImageUploadUseCaseRepository : IUserImageUploadUseCaseRepository
    {
        private readonly IConnectionProvider _connectionProvider;

        public UserImageUploadUseCaseRepository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public async Task<UserProfileImageEntity> GetByUserIdAsync(int userId, CancellationToken cancellationToken)
        {
            var connection = await _connectionProvider.GetConnectionAsync(cancellationToken);

            return (await connection.QueryAsync<UserProfileImageEntity>(UserImageUploadUseCaseCommands.GetByUserIdQuery, new { userId })).FirstOrDefault();
        }

        public async Task UpdateAsync(UserProfileImageEntity userProfile, CancellationToken cancellationToken)
        {
            var connection = await _connectionProvider.GetConnectionAsync(cancellationToken);
            await connection.UpdateAsync(userProfile);
        }

        public async Task InsertAsync(UserProfileImageEntity userProfile, CancellationToken cancellationToken)
        {
            var connection = await _connectionProvider.GetConnectionAsync(cancellationToken);
            await connection.InsertAsync(userProfile);
        }
    }
}