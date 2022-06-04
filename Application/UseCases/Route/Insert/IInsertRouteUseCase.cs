using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Insert
{
    public interface IInsertRouteUseCase
    {
        Task ExecuteAsync(InsertRouteUseCaseInput input, CancellationToken cancellationToken);
    }
}