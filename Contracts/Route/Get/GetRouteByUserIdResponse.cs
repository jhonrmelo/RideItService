using Domain.Entity.Mongo;

using System;
using System.Collections.Generic;

namespace Contracts.Route.Get
{
    public class GetRouteByUserIdResponse
    {
        public IEnumerable<RouteCollection> Routes { get; set; }
    }
}