using Domain.Dto;

using System.Collections.Generic;

namespace Contracts.Route.Get
{
    public class GetRouteResponse
    {
        public IEnumerable<RouteDto> Route { get; set; }

        public bool WasFound { get; set; }
    }
}