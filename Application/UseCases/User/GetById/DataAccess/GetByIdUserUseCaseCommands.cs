namespace Application.UseCases.User.GetById.DataAccess
{
    public static class GetByIdUserUseCaseCommands
    {
        public const string GetByIdQuery = "SELECT * FROM USERS WHERE ID = @ID";
    }
}