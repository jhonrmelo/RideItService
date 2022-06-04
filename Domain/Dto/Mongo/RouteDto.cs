using System;
using System.Collections.Generic;

namespace Domain.Dto.Mongo
{
    public class RouteDto
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }

        public IEnumerable<PointDto> Points { get; set; }
        public IEnumerable<SegmentDto> Segments { get; set; }
    }
}