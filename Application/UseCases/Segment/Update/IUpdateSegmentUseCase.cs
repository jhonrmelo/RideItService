using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.Update
{
    public interface IUpdateSegmentUseCase
    {
        Task ExecuteAsync(UpdateSegmentUseCaseInput input, CancellationToken cancellationToken);
    }
}