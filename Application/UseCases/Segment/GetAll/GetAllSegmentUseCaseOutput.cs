using Domain.Entity;

using System.Collections.Generic;

namespace Application.UseCases.Segment.GetAll
{
    public class GetAllSegmentUseCaseOutput
    {
        public bool WasFound { get; set; }
        public IEnumerable<SegmentEntity> Segment { get; set; }

        public static GetAllSegmentUseCaseOutput Ok(IEnumerable<SegmentEntity> segment)
        {
            return new GetAllSegmentUseCaseOutput()
            {
                Segment = segment,
                WasFound = true
            };
        }

        public static GetAllSegmentUseCaseOutput Fail() => new GetAllSegmentUseCaseOutput() { WasFound = false };
    }
}