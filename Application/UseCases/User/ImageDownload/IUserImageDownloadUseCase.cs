using Microsoft.AspNetCore.Mvc;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageDownload
{
    public interface IUserImageDownloadUseCase
    {
        Task<FileStreamResult> ExecuteAsync(UserImageDownloadUseCaseInput input, CancellationToken cancellationToken);
    }
}