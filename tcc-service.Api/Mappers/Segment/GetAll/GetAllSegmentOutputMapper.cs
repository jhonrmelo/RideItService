using Application.UseCases.Segment.GetAll;

using Contracts.Segment.GetAll;

using Domain.Mappers;

namespace tcc_service.Api.Mappers.Segment.GetAll
{
    public static class GetAllSegmentOutputMapper
    {
        public static GetAllSegmentResponse MapToResponse(this GetAllSegmentUseCaseOutput output)
        {
            return new GetAllSegmentResponse()
            {
                WasFound = output.WasFound,
                Segment = output.Segment.MapToDto()
            };
        }
    }
}