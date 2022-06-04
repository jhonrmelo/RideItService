using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageDownload.DataAccess
{
    public interface IUserImageDownloadUseCaseRepository
    {
        Task<UserProfileImageEntity> GetByUserIdAsync(int userId, CancellationToken cancellationToken);
    }
}