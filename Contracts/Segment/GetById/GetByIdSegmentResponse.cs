using Domain.Dto;

namespace Contracts.Segment.GetById
{
    public class GetByIdSegmentResponse
    {
        public bool WasFound { get; set; }
        public SegmentDto Segment { get; set; }
    }
}