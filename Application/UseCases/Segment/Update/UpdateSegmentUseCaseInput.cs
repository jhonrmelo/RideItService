using Domain.Dto;

using System.Collections.Generic;

namespace Application.UseCases.Segment.Update
{
    public class UpdateSegmentUseCaseInput
    {
        public IEnumerable<SegmentDto> Segments { get; set; }

        public int UserId { get; set; }
    }
}