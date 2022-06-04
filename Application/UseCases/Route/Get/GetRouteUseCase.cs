using Application.UseCases.Route.Get.DataAccess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Get
{
    public class GetRouteUseCase : IGetRouteUseCase
    {
        private IGetRouteRepository getRouteRepository;

        public GetRouteUseCase(IGetRouteRepository getRouteRepository)
        {
            this.getRouteRepository = getRouteRepository;
        }

        public async Task<GetRouteUseCaseOutput> ExecuteAsync(GetRouteUseCaseInput input, CancellationToken cancellationToken)
        {
            var route = await this.getRouteRepository.ExecuteAsync(input.From, input.To, input.Preference);

            if (route is null)
                return GetRouteUseCaseOutput.Fail();

            return GetRouteUseCaseOutput.Ok(route);
        }
    }
}