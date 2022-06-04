using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetById
{
    public interface IGetByIdPointUseCase
    {
        Task<GetByIdPointUseCaseOutput> ExecuteAsync(GetByIdPointUseCaseInput input, CancellationToken cancellationToken);
    }
}