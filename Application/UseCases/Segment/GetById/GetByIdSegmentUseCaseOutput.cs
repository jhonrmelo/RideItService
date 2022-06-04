using Domain.Entity;

namespace Application.UseCases.Segment.GetById
{
    public class GetByIdSegmentUseCaseOutput
    {
        public bool WasFound { get; set; }
        public SegmentEntity Segment { get; set; }

        public static GetByIdSegmentUseCaseOutput Ok(SegmentEntity segment)
        {
            return new GetByIdSegmentUseCaseOutput()
            {
                Segment = segment,
                WasFound = true
            };
        }

        public static GetByIdSegmentUseCaseOutput Fail() => new GetByIdSegmentUseCaseOutput() { WasFound = false };
    }
}