using Amazon.S3;
using Amazon.S3.Model;

using Application.UseCases.User.ImageUpload.DataAccess;

using Domain.Entity;

using Microsoft.Extensions.Configuration;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.ImageUpload
{
    public class UserImageUploadUseCase : IUserImageUploadUseCase
    {
        private readonly IAmazonS3 amazonS3;
        private readonly IUserImageUploadUseCaseRepository userImageUploadUseCaseRepository;
        private readonly string awsBucket;

        public UserImageUploadUseCase(IAmazonS3 amazonS3, IConfiguration configuration, IUserImageUploadUseCaseRepository userImageUploadUseCaseRepository)
        {
            this.amazonS3 = amazonS3;
            this.userImageUploadUseCaseRepository = userImageUploadUseCaseRepository;
            awsBucket = configuration["AWS:BucketName"];
        }

        public async Task ExecuteAsync(UserImageUploadUseCaseInput input, CancellationToken cancellationToken)
        {
            var userActualProfileImage = await this.userImageUploadUseCaseRepository.GetByUserIdAsync(input.UserId, cancellationToken);

            if (userActualProfileImage != null)
            {
                userActualProfileImage.Deactivate();
                await this.userImageUploadUseCaseRepository.UpdateAsync(userActualProfileImage, cancellationToken);
            }

            var userProfileImage = this.GetUserProfileImage(input);

            await this.userImageUploadUseCaseRepository.InsertAsync(userProfileImage, cancellationToken);

            var putRequest = new PutObjectRequest()
            {
                BucketName = awsBucket,
                Key = userProfileImage.ProfileImageName,
                InputStream = input.Image.OpenReadStream(),
                ContentType = input.Image.ContentType,
            };

            await this.amazonS3.PutObjectAsync(putRequest);
        }

        public UserProfileImageEntity GetUserProfileImage(UserImageUploadUseCaseInput input)
        {
            string imageExtension = Path.GetExtension(input.Image.FileName);

            return new UserProfileImageEntity()
            {
                Status = true,
                UserId = input.UserId,
                ProfileImageName = $"{Guid.NewGuid()}{imageExtension}"
            };
        }
    }
}