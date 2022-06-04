using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Authenticate
{
    public interface IAuthenticateUseCase
    {
        Task<AuthenticateOutput> ExecuteAsync(AuthenticateInput authenticateInput, CancellationToken cancellationToken);
    }
}