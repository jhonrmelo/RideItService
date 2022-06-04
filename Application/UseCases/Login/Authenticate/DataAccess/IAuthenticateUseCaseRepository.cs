using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Authenticate.DataAccess
{
    public interface IAuthenticateUseCaseRepository
    {
        Task<UsersEntity> GetUserByLoginAsync(string email, string password, CancellationToken cancellationToken);
    }
}