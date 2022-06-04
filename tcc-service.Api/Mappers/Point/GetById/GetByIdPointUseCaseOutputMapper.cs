using Application.UseCases.Point.GetById;

using Contracts.Point.GetById;

using Domain.Mappers;

namespace tcc_service.Api.Mappers.Point.GetById
{
    public static class GetByIdPointUseCaseOutputMapper
    {
        public static GetByIdPointResponse MapToResponse(this GetByIdPointUseCaseOutput output)
            => new GetByIdPointResponse()
            {
                PointDto = output.Point.MapToDto(),
                WasFound = output.WasFound
            };
    }
}