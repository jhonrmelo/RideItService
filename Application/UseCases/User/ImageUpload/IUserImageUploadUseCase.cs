using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageUpload
{
    public interface IUserImageUploadUseCase
    {
        Task ExecuteAsync(UserImageUploadUseCaseInput input, CancellationToken cancellationToken);
    }
}