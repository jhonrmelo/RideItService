using Domain.Entity;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetAll.DataAcess
{
    public interface IGetAllPointUseCaseRepository
    {
        Task<IEnumerable<PointEntity>> GetAll();
    }
}