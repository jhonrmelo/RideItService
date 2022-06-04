using Application.UseCases.Route.GetByUserId.DataAccess;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.GetByUserId
{
    public class GetRouteByUserIdUseCase : IGetRouteByUserIdUseCase
    {
        private IGetRouteByUserIdRepository _getRouteByUserIdRepository;

        public GetRouteByUserIdUseCase(IGetRouteByUserIdRepository getRouteByUserIdRepository)
        {
            _getRouteByUserIdRepository = getRouteByUserIdRepository;
        }

        public async Task<GetRouteByUserIdOutput> ExecuteAsync(GetRouteByUserIdUseCaseInput input, CancellationToken cancellationToken)
        {
            var userRoutes = await _getRouteByUserIdRepository.GetUserRoutesAsync(input.UserId, cancellationToken);

            if (userRoutes is null)
                return GetRouteByUserIdOutput.NotFound();

            return GetRouteByUserIdOutput.Ok(userRoutes.OrderBy(route => route.InsertedDate));
        }
    }
}