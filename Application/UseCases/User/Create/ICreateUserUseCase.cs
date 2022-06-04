using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.User.Create
{
    public interface ICreateUserUseCase
    {
        Task<CreateUserUseCaseOutput> ExecuteAsync(CreateUserUseCaseInput input, CancellationToken cancellationToken);
    }
}