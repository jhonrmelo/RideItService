using System.Collections.Generic;

namespace Domain.Entity
{
    public class RouteEntity
    {
        public IEnumerable<PointEntity> Points { get; set; }
        public IEnumerable<SegmentEntity> Segments { get; set; }
    }
}