using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Update
{
    public interface IUpdateUserUseCase
    {
        Task<UpdateUserUseCaseOutput> ExecuteAsync(UpdateUserUseCaseInput input, CancellationToken cancellationToken);
    }
}