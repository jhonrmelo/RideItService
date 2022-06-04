using Application.UseCases.User.Update;

using Contracts.User.Update;

namespace tcc_service.Api.Mappers.User.UpdateUser
{
    public static class UpdateUserRequestMapper
    {
        public static UpdateUserUseCaseInput MapToInput(this UpdateUserRequest request)
            => new UpdateUserUseCaseInput()
            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                BirthDate = request.BirthDate,
                Gender = request.Gender,
                Status = request.Status
            };
    }
}