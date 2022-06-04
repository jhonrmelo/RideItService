using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetAll
{
    public interface IGetAllPointUseCase
    {
        Task<GetAllPointUseCaseOutput> ExecuteAsync(CancellationToken cancellationToken);
    }
}