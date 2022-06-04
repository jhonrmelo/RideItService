using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Update.DataAccess
{
    public interface IUpdateUserUseCaseRepository
    {
        Task Update(UsersEntity user, CancellationToken cancellationToken);
    }
}