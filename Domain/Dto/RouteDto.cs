using System.Collections.Generic;

namespace Domain.Dto
{
    public class RouteDto
    {
        public IEnumerable<PointDto> Points { get; set; }
        public IEnumerable<SegmentDto> Segments { get; set; }
    }
}