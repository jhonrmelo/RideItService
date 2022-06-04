using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetAll
{
    public interface IGetAllUserUseCase
    {
        Task<GetAllUserUseCaseOutput> ExecuteAsync(CancellationToken cancellationToken);
    }
}