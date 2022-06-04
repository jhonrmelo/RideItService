using Application.UseCases.Authenticate;

using Contracts.Login.Authenticate;

using Domain.Dto;

namespace tcc_service.Api.Mappers.Authenticate
{
    public static class AuthenticateOutputMapper
    {
        public static AuthenticateResponse MapToResponse(this AuthenticateOutput authenticateOutput)
            => new AuthenticateResponse()
            {
                IsAuthenticated = authenticateOutput.IsAuthenticated,
                Token = authenticateOutput.Token,
                User = new UsersDto()
                {
                    Email = authenticateOutput.User.Email,
                    Id = authenticateOutput.User.Id,
                    Name = authenticateOutput.User.Name,
                    BirthDate = authenticateOutput.User.BirthDate,
                    Gender = authenticateOutput.User.Gender,
                    Status = authenticateOutput.User.Status
                }
            };
    }
}