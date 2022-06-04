using Application.UseCases.Route.Insert.DataAccess;

using Domain.Mappers;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Route.Insert
{
    public class InsertRouteUseCase : IInsertRouteUseCase
    {
        private IInsertRouteRepository insertRouteRepository;

        public InsertRouteUseCase(IInsertRouteRepository insertRouteRepository)
        {
            this.insertRouteRepository = insertRouteRepository;
        }

        public async Task ExecuteAsync(InsertRouteUseCaseInput input, CancellationToken cancellationToken)
        {
            foreach (var segment in input.Route.Segments)
            {
                segment.ClearRatings();
            }

            await this.insertRouteRepository.InsertAsync(input.Route.MapToCollection(), cancellationToken);

            return;
        }
    }
}