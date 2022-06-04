namespace Application.UseCases.User.ImageDownload.DataAccess
{
    public class UserImageDownloadUseCaseCommands
    {
        public const string GetByUserIdQuery = "SELECT * FROM USERPROFILEIMAGE WHERE USERID = @USERID AND STATUS = 1";
    }
}