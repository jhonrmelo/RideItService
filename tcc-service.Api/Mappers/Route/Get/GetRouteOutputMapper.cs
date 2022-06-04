using Application.UseCases.Route.Get;

using Contracts.Route.Get;

using Domain.Mappers;

namespace tcc_service.Api.Mappers.Route.Get
{
    public static class GetRouteOutputMapper
    {
        public static GetRouteResponse MapToResponse(this GetRouteUseCaseOutput output)
            => new GetRouteResponse()
            {
                Route = output.Routes.MapToDto(),
                WasFound = output.WasFound
            };
    }
}