using Application.UseCases.Point.GetAll.DataAcess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetAll
{
    public class GetAllPointUseCase : IGetAllPointUseCase
    {
        private readonly IGetAllPointUseCaseRepository _getAllPointUseCaseRepository;

        public GetAllPointUseCase(IGetAllPointUseCaseRepository getAllPointUseCaseRepository)
        {
            _getAllPointUseCaseRepository = getAllPointUseCaseRepository;
        }

        public async Task<GetAllPointUseCaseOutput> ExecuteAsync(CancellationToken cancellationToken)
        {
            var point = await _getAllPointUseCaseRepository.GetAll();

            if (point is null)
                return GetAllPointUseCaseOutput.Fail();

            return GetAllPointUseCaseOutput.Ok(point);
        }
    }
}