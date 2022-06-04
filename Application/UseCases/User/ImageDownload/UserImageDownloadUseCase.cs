using Amazon.S3;
using Amazon.S3.Model;

using Application.UseCases.User.ImageDownload.DataAccess;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageDownload
{
    public class UserImageDownloadUseCase : IUserImageDownloadUseCase
    {
        private readonly IAmazonS3 amazonS3;
        private readonly string awsBucket;
        private readonly IUserImageDownloadUseCaseRepository _userImageDownloadUseCaseRepository;

        public UserImageDownloadUseCase(
            IAmazonS3 amazonS3,
            IConfiguration configuration,
            IUserImageDownloadUseCaseRepository userImageDownloadUseCaseRepository
            )
        {
            this.amazonS3 = amazonS3;
            awsBucket = configuration["AWS:BucketName"];
            _userImageDownloadUseCaseRepository = userImageDownloadUseCaseRepository;
        }

        public async Task<FileStreamResult> ExecuteAsync(UserImageDownloadUseCaseInput input, CancellationToken cancellationToken)
        {
            var img = await _userImageDownloadUseCaseRepository.GetByUserIdAsync(input.UserId, cancellationToken);

            var request = new GetObjectRequest()
            {
                BucketName = awsBucket,
                Key = img.ProfileImageName
            };

            using GetObjectResponse response = await this.amazonS3.GetObjectAsync(request);
            using Stream responseStream = response.ResponseStream;
            var stream = new MemoryStream();
            await responseStream.CopyToAsync(stream);
            stream.Position = 0;

            return new FileStreamResult(stream, response.Headers["Content-Type"])
            {
                FileDownloadName = img.ProfileImageName
            };
        }
    }
}