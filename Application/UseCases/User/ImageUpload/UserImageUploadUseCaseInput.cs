using Microsoft.AspNetCore.Http;

namespace Application.UseCases.User.ImageUpload
{
    public class UserImageUploadUseCaseInput
    {
        public UserImageUploadUseCaseInput(IFormFile image, int userId)
        {
            Image = image;
            UserId = userId;
        }

        public IFormFile Image { get; set; }
        public int UserId { get; set; }
    }
}