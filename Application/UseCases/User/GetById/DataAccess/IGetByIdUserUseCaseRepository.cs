using Domain.Entity;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetById.DataAccess
{
    public interface IGetByIdUserUseCaseRepository
    {
        Task<UsersEntity> GetById(int id, CancellationToken cancellationToken);
    }
}