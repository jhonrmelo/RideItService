using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Update.Update.DataAcess
{
    public interface IUpdateSegmentUseCaseRepository
    {
        Task Update(IEnumerable<SegmentEntity> segment);

        Task<IEnumerable<SegmentEntity>> GetById(IEnumerable<string> ids);
    }
}