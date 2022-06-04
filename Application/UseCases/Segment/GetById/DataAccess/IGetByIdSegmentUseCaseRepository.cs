using Domain.Entity;

using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetById.DataAcess
{
    public interface IGetByIdSegmentUseCaseRepository
    {
        Task<SegmentEntity> GetById(string id);
    }
}