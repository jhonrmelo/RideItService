using Domain.Entity.Mongo;

using System;
using System.Collections.Generic;

namespace Application.UseCases.Route.GetByUserId
{
    public class GetRouteByUserIdOutput
    {
        public bool HasValue { get; set; }

        public IEnumerable<RouteCollection> Routes { get; set; }

        public static GetRouteByUserIdOutput NotFound()
            => new GetRouteByUserIdOutput() { HasValue = false };

        public static GetRouteByUserIdOutput Ok(IEnumerable<RouteCollection> routes)
            => new GetRouteByUserIdOutput() { Routes = routes, HasValue = true };
    }
}