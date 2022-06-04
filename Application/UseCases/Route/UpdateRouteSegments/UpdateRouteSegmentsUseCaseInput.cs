using Contracts.Route.UpdateSegments;

using Domain.Dto.Mongo;

using System;
using System.Collections.Generic;

namespace Application.UseCases.Route.UpdateRouteSegments
{
    public class UpdateRouteSegmentsUseCaseInput
    {
        public Guid RouteID { get; set; }

        public IEnumerable<RouteSegment> UserRouteSegments { get; set; }
    }
}