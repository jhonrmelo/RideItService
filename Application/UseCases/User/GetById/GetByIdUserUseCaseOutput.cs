using Domain.Entity;

namespace Application.UseCases.User.GetById
{
    public class GetByIdUserUseCaseOutput
    {
        public GetByIdUserUseCaseOutput(UsersEntity User,
            bool hasExecutedWithoutError,
            string message)
        {
            this.User = User;
            HasExecutedWithoutError = hasExecutedWithoutError;
            Message = message;
        }

        public GetByIdUserUseCaseOutput(
            bool hasExecutedWithoutError,
            string message)

        {
            HasExecutedWithoutError = hasExecutedWithoutError;
            Message = message;
        }

        public UsersEntity User { get; set; }

        public bool HasExecutedWithoutError { get; set; }

        public string Message { get; set; }

        public static GetByIdUserUseCaseOutput Ok(UsersEntity user) => new GetByIdUserUseCaseOutput(
            user,
            hasExecutedWithoutError: true,
            message: "Sucesso");

        public static GetByIdUserUseCaseOutput Fail() => new GetByIdUserUseCaseOutput(hasExecutedWithoutError: false, message: "Erro");

        public static GetByIdUserUseCaseOutput NoContent() => new GetByIdUserUseCaseOutput(hasExecutedWithoutError: false, message: "Usuário não encontrado");
    }
}