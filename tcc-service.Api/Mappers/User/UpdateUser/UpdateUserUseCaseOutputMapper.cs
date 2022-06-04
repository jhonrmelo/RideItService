using Application.UseCases.User.Update;

using Contracts.User.Update;

namespace tcc_service.Api.Mappers.User.UpdateUser
{
    public static class UpdateUserUseCaseOutputMapper
    {
        public static UpdateUserResponse MapToResponse(this UpdateUserUseCaseOutput updateUserUseCaseOutput)
            => new UpdateUserResponse()
            {
                Updated = updateUserUseCaseOutput.Updated
            };
    }
}
