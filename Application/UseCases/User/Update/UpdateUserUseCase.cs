using Application.UseCases.User.GetById.DataAccess;
using Application.UseCases.User.Update.DataAccess;

using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Update
{
    public class UpdateUserUseCase : IUpdateUserUseCase
    {
        private readonly IUpdateUserUseCaseRepository _updateUserUseCaseRepository;
        private readonly IGetByIdUserUseCaseRepository _getByIdUserUseCaseRepository;

        public UpdateUserUseCase(IUpdateUserUseCaseRepository updateUserUseCaseRepository,
                                 IGetByIdUserUseCaseRepository getByIdUserUseCaseRepository)
        {
            _updateUserUseCaseRepository = updateUserUseCaseRepository;
            _getByIdUserUseCaseRepository = getByIdUserUseCaseRepository;
        }

        public async Task<UpdateUserUseCaseOutput> ExecuteAsync(UpdateUserUseCaseInput input, CancellationToken cancellationToken)
        {
            var user = await _getByIdUserUseCaseRepository.GetById(input.Id, cancellationToken);

            if (user is null)
                return UpdateUserUseCaseOutput.Fail();

            if (string.IsNullOrEmpty(input.Password))
                input.Password = user.Password;

            await _updateUserUseCaseRepository.Update(input.UpdateUser(), cancellationToken);

            return UpdateUserUseCaseOutput.Ok();
        }
    }
}