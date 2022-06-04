using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.GetByUserId
{
    public interface IGetRouteByUserIdUseCase
    {
        Task<GetRouteByUserIdOutput> ExecuteAsync(GetRouteByUserIdUseCaseInput input, CancellationToken cancellationToken);
    }
}