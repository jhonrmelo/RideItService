using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Get
{
    public interface IGetRouteUseCase
    {
        Task<GetRouteUseCaseOutput> ExecuteAsync(GetRouteUseCaseInput input, CancellationToken cancellationToken);
    }
}