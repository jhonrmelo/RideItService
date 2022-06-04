using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetById
{
    public interface IGetByIdUserUseCase
    {
        Task<GetByIdUserUseCaseOutput> ExecuteAsync(GetByIdUserUseCaseInput input, CancellationToken cancellationToken);
    }
}