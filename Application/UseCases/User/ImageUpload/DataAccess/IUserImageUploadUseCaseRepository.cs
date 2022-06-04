using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageUpload.DataAccess
{
    public interface IUserImageUploadUseCaseRepository
    {
        Task<UserProfileImageEntity> GetByUserIdAsync(int userId, CancellationToken cancellationToken);

        Task UpdateAsync(UserProfileImageEntity userProfile, CancellationToken cancellationToken);

        Task InsertAsync(UserProfileImageEntity userProfile, CancellationToken cancellationToken);
    }
}