using Application.UseCases.User.GetAll;

using Contracts.User.GetAll;

using Domain.Mappers;

using System.Linq;

namespace tcc_service.Api.Mappers.User.GetAllUser
{
    public static class GetAllUserUseCaseOutputMapper
    {
        public static GetAllUserResponse MapToResponse(this GetAllUserUseCaseOutput output)
            => new GetAllUserResponse()
            {
                Users = output.Users.Select(user => user.MapToDto())
            };
    }
}