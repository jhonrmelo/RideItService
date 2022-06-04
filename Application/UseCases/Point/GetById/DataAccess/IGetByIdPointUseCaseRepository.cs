using Domain.Entity;

using System.Threading.Tasks;

namespace Application.UseCases.Point.GetById.DataAcess
{
    public interface IGetByIdPointUseCaseRepository
    {
        Task<PointEntity> GetById(string id);
    }
}