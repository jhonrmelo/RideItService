namespace Application.UseCases.User.ImageDownload
{
    public class UserImageDownloadUseCaseInput
    {
        public UserImageDownloadUseCaseInput(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; set; }
    }
}