namespace Application.UseCases.User.Create.DataAccess
{
    public static class CreateUserUseCaseCommands
    {
        public const string GetByEmailQuery = "SELECT * FROM USERS WHERE EMAIL = @EMAIL";
    }
}