using Domain.Entity;

using System.Collections.Generic;

namespace Application.UseCases.Route.Get
{
    public class GetRouteUseCaseOutput
    {
        public IEnumerable<RouteEntity> Routes { get; set; }
        public bool WasFound { get; set; }

        public static GetRouteUseCaseOutput Ok(IEnumerable<RouteEntity> routes)
            => new GetRouteUseCaseOutput() { Routes = routes, WasFound = true };

        public static GetRouteUseCaseOutput Fail() => new GetRouteUseCaseOutput();
    }
}