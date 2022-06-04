using Application.UseCases.Point.GetById.DataAcess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Point.GetById
{
    public class GetByIdPointUseCase : IGetByIdPointUseCase
    {
        private readonly IGetByIdPointUseCaseRepository _getByIdPointUseCaseRepository;

        public GetByIdPointUseCase(IGetByIdPointUseCaseRepository getByIdPointUseCaseRepository)
        {
            _getByIdPointUseCaseRepository = getByIdPointUseCaseRepository;
        }

        public async Task<GetByIdPointUseCaseOutput> ExecuteAsync(GetByIdPointUseCaseInput input, CancellationToken cancellationToken)
        {
            var point = await _getByIdPointUseCaseRepository.GetById(input.Id);

            if (point is null)
                return GetByIdPointUseCaseOutput.Fail();

            return GetByIdPointUseCaseOutput.Ok(point);
        }
    }
}