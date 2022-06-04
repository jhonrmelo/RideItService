using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Segment.GetAll.DataAcess
{
    public interface IGetAllSegmentUseCaseRepository
    {
        Task<IEnumerable<SegmentEntity>> GetAll();
    }
}