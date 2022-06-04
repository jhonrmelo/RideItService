using Application.UseCases.User.GetById.DataAccess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetById
{
    public class GetByIdUserUseCase : IGetByIdUserUseCase
    {
        private IGetByIdUserUseCaseRepository _getByIdUserUseCaseRepository;

        public GetByIdUserUseCase(IGetByIdUserUseCaseRepository getByIdUserUseCaseRepository)
        {
            _getByIdUserUseCaseRepository = getByIdUserUseCaseRepository;
        }

        public async Task<GetByIdUserUseCaseOutput> ExecuteAsync(GetByIdUserUseCaseInput input, CancellationToken cancellationToken)
        {
            var user = await _getByIdUserUseCaseRepository.GetById(input.Id, cancellationToken);

            if (user != null)
            {
                return GetByIdUserUseCaseOutput.Ok(user);
            }

            return GetByIdUserUseCaseOutput.NoContent();
        }
    }
}