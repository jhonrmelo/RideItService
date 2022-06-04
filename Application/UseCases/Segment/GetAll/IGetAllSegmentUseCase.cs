using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetAll
{
    public interface IGetAllSegmentUseCase
    {
        Task<GetAllSegmentUseCaseOutput> ExecuteAsync(CancellationToken cancellationToken);
    }
}