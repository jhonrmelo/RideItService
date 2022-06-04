using Domain.Dto;

using System.Collections.Generic;

namespace Contracts.Segment.GetAll
{
    public class GetAllSegmentResponse
    {
        public bool WasFound { get; set; }
        public IEnumerable<SegmentDto> Segment { get; set; }
    }
}