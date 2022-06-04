using Application.UseCases.User.Create;

using Contracts.User.Create;

namespace tcc_service.Api.Mappers.User.CreateUser
{
    public static class CreateUserUseCaseOutputMapper
    {
        public static CreateUserResponse MapToResponse(this CreateUserUseCaseOutput output)
            => new CreateUserResponse()
            {
                Inserted = output.Inserted
            };
    }
}