using Application.UseCases.Segment.GetAll.DataAcess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetAll
{
    public class GetAllSegmentUseCase : IGetAllSegmentUseCase
    {
        private readonly IGetAllSegmentUseCaseRepository _getAllSegmentUseCaseRepository;

        public GetAllSegmentUseCase(IGetAllSegmentUseCaseRepository getAllSegmentUseCaseRepository)
        {
            _getAllSegmentUseCaseRepository = getAllSegmentUseCaseRepository;
        }

        public async Task<GetAllSegmentUseCaseOutput> ExecuteAsync(CancellationToken cancellationToken)
        {
            var segment = await _getAllSegmentUseCaseRepository.GetAll();

            if (segment is null)
                return GetAllSegmentUseCaseOutput.Fail();

            return GetAllSegmentUseCaseOutput.Ok(segment);
        }
    }
}