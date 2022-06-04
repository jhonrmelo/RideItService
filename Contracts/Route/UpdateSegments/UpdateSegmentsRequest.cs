using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Route.UpdateSegments
{
    public class UpdateRouteSegmentsRequest
    {
        public IEnumerable<RouteSegment> RouteSegments { get; set; }
    }
}