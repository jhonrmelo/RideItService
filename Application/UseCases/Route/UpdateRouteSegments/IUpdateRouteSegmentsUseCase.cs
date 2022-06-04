using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.UpdateRouteSegments
{
    public interface IUpdateRouteSegmentsUseCase
    {
        Task ExecuteAsync(UpdateRouteSegmentsUseCaseInput input, CancellationToken cancellationToken);
    }
}