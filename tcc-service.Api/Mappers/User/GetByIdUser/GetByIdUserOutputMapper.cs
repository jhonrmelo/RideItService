using Application.UseCases.User.GetById;

using Contracts.User.GetById;

using Domain.Mappers;

namespace tcc_service.Api.Mappers.User.GetByIdUser
{
    public static class GetByIdUserOutputMapper
    {
        public static GetByIdUserResponse MapToResponse(this GetByIdUserUseCaseOutput output)
            => new GetByIdUserResponse()
            {
                Users = output.User.MapToDto(),
                HasExecutedWithoutError = output.HasExecutedWithoutError,
                Message = output.Message
            };
    }
}