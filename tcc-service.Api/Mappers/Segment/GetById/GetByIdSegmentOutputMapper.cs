using Application.UseCases.Segment.GetById;

using Contracts.Segment.GetById;

using Domain.Mappers;

namespace tcc_service.Api.Mappers.Segment.GetById
{
    public static class GetByIdSegmentUseCaseOutputMapper
    {
        public static GetByIdSegmentResponse MapToResponse(this GetByIdSegmentUseCaseOutput output)
        {
            return new GetByIdSegmentResponse()
            {
                WasFound = output.WasFound,
                Segment = output.Segment.MapToDto()
            };
        }
    }
}