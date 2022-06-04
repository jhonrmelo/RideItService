using Domain.Entity;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetAll.DataAccess
{
    public interface IGetAllUserUseCaseRepository
    {
        Task<IEnumerable<UsersEntity>> GetAll(CancellationToken cancellationToken);
    }
}