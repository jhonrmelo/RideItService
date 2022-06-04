using Application.UseCases.Point.GetAll;

using Contracts.Point.GetAllPointResponse;

using Domain.Mappers;

namespace tcc_service.Api.Mappers.Point.GetAll
{
    public static class GetAllPointUseCaseOutputMapper
    {
        public static GetAllPointResponse MapToResponse(this GetAllPointUseCaseOutput output)
            => new GetAllPointResponse()
            {
                PointsDto = output.Points.MapToDto(),
                WasFound = output.WasFound
            };
    }
}