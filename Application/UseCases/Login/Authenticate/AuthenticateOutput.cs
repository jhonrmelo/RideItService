using Domain.Entity;

namespace Application.UseCases.Authenticate
{
    public class AuthenticateOutput
    {
        public AuthenticateOutput(UsersEntity user, bool isAuthenticated, string token)
        {
            User = user;
            IsAuthenticated = isAuthenticated;
            Token = token;
        }

        public UsersEntity User { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Token { get; set; }

        public static AuthenticateOutput Ok(UsersEntity user, string token)
        {
            return new AuthenticateOutput(user, isAuthenticated: true, token: token);
        }

        public static AuthenticateOutput NotAuthenticated(UsersEntity user)
        {
            return new AuthenticateOutput(user, isAuthenticated: false, token: string.Empty);
        }
    }
}