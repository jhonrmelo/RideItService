using Application.UseCases.User.Create;

using Contracts.User.Create;

namespace tcc_service.Api.Mappers.User.CreateUser
{
    public static class CreateUserRequestMapper
    {
        public static CreateUserUseCaseInput MapToInput(this CreateUserRequest request)
            => new CreateUserUseCaseInput()
            {
                Email = request.Email,
                Name = request.Name,
                Password = request.Password,
                BirthDate = request.BirthDate,
                Gender = request.Gender,
            };
    }
}