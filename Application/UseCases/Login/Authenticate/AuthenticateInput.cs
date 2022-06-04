namespace Application.UseCases.Authenticate
{
    public class AuthenticateInput
    {
        public AuthenticateInput(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Password { get; set; }
        public string Email { get; set; }
    }
}