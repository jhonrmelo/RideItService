using Application.UseCases.Route.Insert.DataAccess;
using Application.UseCases.Route.UpdateRouteSegments.DataAccess;

using Domain.Mappers;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.UpdateRouteSegments
{
    public class UpdateRouteSegmentsUseCase : IUpdateRouteSegmentsUseCase
    {
        private IUpdateRouteSegmentsRepository updateRouteSegmentsRepository;

        public UpdateRouteSegmentsUseCase(IUpdateRouteSegmentsRepository updateRouteSegmentsRepository)
        {
            this.updateRouteSegmentsRepository = updateRouteSegmentsRepository;
        }

        public async Task ExecuteAsync(UpdateRouteSegmentsUseCaseInput input, CancellationToken cancellationToken)
        {
            var userRoutes = await this.updateRouteSegmentsRepository.GetUserRoute(input.RouteID, cancellationToken);

            var mapUpdatedSegments = input.UserRouteSegments.GroupBy(segment => segment._id).ToDictionary(keySelector => keySelector.Key, comparer => comparer.FirstOrDefault());

            foreach (var segment in userRoutes.Segments)
            {
                if (!mapUpdatedSegments.ContainsKey(segment._id))
                    continue;

                var updatedSegment = mapUpdatedSegments[segment._id];

                segment.AverageBikeLane = updatedSegment.AverageBikeLane;
                segment.AverageLight = updatedSegment.AverageLight;
                segment.AverageStreet = updatedSegment.AverageStreet;
            }

            await this.updateRouteSegmentsRepository.Update(userRoutes, cancellationToken);
        }
    }
}