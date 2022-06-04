using Domain.Dto;

using System.Collections.Generic;

namespace Contracts.Segment.Update
{
    public class UpdateSegmentRequest
    {
        public IEnumerable<SegmentDto> Segment { get; set; }
    }
}