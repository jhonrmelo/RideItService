using Application.UseCases.User.Create.DataAccess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Create
{
    public class CreateUserUseCase : ICreateUserUseCase
    {
        private ICreateUserUseCaseRepository _createUserUseCaseRepository;

        public CreateUserUseCase(ICreateUserUseCaseRepository createUserUseCaseRepository)
        {
            _createUserUseCaseRepository = createUserUseCaseRepository;
        }

        public async Task<CreateUserUseCaseOutput> ExecuteAsync(CreateUserUseCaseInput input, CancellationToken cancellationToken)
        {
            var user = await _createUserUseCaseRepository.GetByEmail(input.Email, cancellationToken);

            if (user != null)
                return CreateUserUseCaseOutput.Fail();

            await _createUserUseCaseRepository.Create(input.CreateUser(), cancellationToken);

            return CreateUserUseCaseOutput.Ok();
        }
    }
}