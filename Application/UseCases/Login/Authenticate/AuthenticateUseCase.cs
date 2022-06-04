using Application.Shared.Infra.ArangoDb;
using Application.UseCases.Authenticate.DataAccess;

using Domain.Configuration;
using Domain.Entity;

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Authenticate
{
    public class AuthenticateUseCase : IAuthenticateUseCase
    {
        private readonly AuthConfig _authConfig;
        private readonly IAuthenticateUseCaseRepository _authenticateUseCaseRepository;

        public AuthenticateUseCase(IOptions<AuthConfig> authConfig, IAuthenticateUseCaseRepository authenticateUseCaseRepository, IArangoDbConnectionProvider arangoDbConnectionProvider)
        {
            _authConfig = authConfig.Value;
            _authenticateUseCaseRepository = authenticateUseCaseRepository;
        }

        public async Task<AuthenticateOutput> ExecuteAsync(AuthenticateInput authenticateInput, CancellationToken cancellationToken)
        {
            var user = await _authenticateUseCaseRepository.GetUserByLoginAsync(authenticateInput.Email, authenticateInput.Password, cancellationToken);

            if (user is null)
                return AuthenticateOutput.NotAuthenticated(user);

            string token = this.GenerateToken(user);

            return AuthenticateOutput.Ok(user, token);
        }

        private string GenerateToken(UsersEntity user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_authConfig.Key);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                                                                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}