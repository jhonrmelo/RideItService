using Domain.Dto;

namespace Contracts.Login.Authenticate
{
    public class AuthenticateResponse
    {
        public UsersDto User { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Token { get; set; }
    }
}