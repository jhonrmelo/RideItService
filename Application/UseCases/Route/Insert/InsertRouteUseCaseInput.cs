using Domain.Dto.Mongo;

namespace Application.UseCases.Route.Insert
{
    public class InsertRouteUseCaseInput
    {
        public int UserId { get; set; }
        public RouteDto Route { get; set; }
    }
}