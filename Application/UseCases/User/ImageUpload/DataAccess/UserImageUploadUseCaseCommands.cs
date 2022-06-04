namespace Application.UseCases.User.ImageUpload.DataAccess
{
    public class UserImageUploadUseCaseCommands
    {
        public const string GetByUserIdQuery = "SELECT * FROM USERPROFILEIMAGE WHERE USERID = @USERID AND STATUS = 1";
    }
}