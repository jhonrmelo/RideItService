using Application.UseCases.User.GetAll.DataAccess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.GetAll
{
    public class GetAllUserUseCase : IGetAllUserUseCase
    {
        private IGetAllUserUseCaseRepository _getAllUserUseCaseRepository;

        public GetAllUserUseCase(IGetAllUserUseCaseRepository getAllUserUseCaseRepository)
        {
            _getAllUserUseCaseRepository = getAllUserUseCaseRepository;
        }

        public async Task<GetAllUserUseCaseOutput> ExecuteAsync(CancellationToken cancellationToken)
        {
            var users = await _getAllUserUseCaseRepository.GetAll(cancellationToken);

            if (users != null)
                return GetAllUserUseCaseOutput.Ok(users);

            return GetAllUserUseCaseOutput.Fail();
        }
    }
}