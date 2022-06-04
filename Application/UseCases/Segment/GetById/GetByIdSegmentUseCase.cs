using Application.UseCases.Segment.GetById.DataAcess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetById
{
    public class GetByIdSegmentUseCase : IGetByIdSegmentUseCase
    {
        private readonly IGetByIdSegmentUseCaseRepository _getByIdSegmentUseCaseRepository;

        public GetByIdSegmentUseCase(IGetByIdSegmentUseCaseRepository getByIdSegmentUseCaseRepository)
        {
            _getByIdSegmentUseCaseRepository = getByIdSegmentUseCaseRepository;
        }

        public async Task<GetByIdSegmentUseCaseOutput> ExecuteAsync(GetByIdSegmentUseCaseInput input, CancellationToken cancellationToken)
        {
            var segment = await _getByIdSegmentUseCaseRepository.GetById(input.Id);

            if (segment is null)
                return GetByIdSegmentUseCaseOutput.Fail();

            return GetByIdSegmentUseCaseOutput.Ok(segment);
        }
    }
}