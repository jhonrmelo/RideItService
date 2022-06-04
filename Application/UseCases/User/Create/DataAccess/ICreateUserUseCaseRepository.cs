using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Create.DataAccess
{
    public interface ICreateUserUseCaseRepository
    {
        Task Create(UsersEntity user, CancellationToken cancellationToken);

        Task<UsersEntity> GetByEmail(string email, CancellationToken cancellationToken);
    }
}