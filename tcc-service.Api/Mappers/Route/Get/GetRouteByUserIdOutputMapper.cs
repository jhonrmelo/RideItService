using Application.UseCases.Route.GetByUserId;

using Contracts.Route.Get;

namespace tcc_service.Api.Mappers.Route.Get
{
    public static class GetRouteByUserIdOutputMapper
    {
        public static GetRouteByUserIdResponse MapToResponse(this GetRouteByUserIdOutput output)
            => new GetRouteByUserIdResponse()
            {
                Routes = output.Routes
            };
    }
}