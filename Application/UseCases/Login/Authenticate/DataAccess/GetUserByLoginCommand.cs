namespace Application.UseCases.Authenticate.DataAccess
{
    public static class GetUserByLoginCommand
    {
        public static string Query = @"SELECT  *
                                       FROM USERS
                                       WHERE EMAIL = @EMAIL
                                       AND PASSWORD = @PASSWORD
                                       AND STATUS = 1";
    }
}