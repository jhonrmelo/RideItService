using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetById
{
    public interface IGetByIdSegmentUseCase
    {
        Task<GetByIdSegmentUseCaseOutput> ExecuteAsync(GetByIdSegmentUseCaseInput input, CancellationToken cancellationToken);
    }
}