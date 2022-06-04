using Domain.Dto;
using Domain.Entity;

using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class RouteEntityMapper
    {
        public static RouteDto MapToDto(this RouteEntity entity)
            => new RouteDto()
            {
                Points = entity.Points.MapToDto(),
                Segments = entity.Segments.MapToDto()
            };

        public static IEnumerable<RouteDto> MapToDto(this IEnumerable<RouteEntity> entities)
        {
            List<RouteDto> routes = new List<RouteDto>();

            foreach (var entity in entities)
            {
                routes.Add(entity.MapToDto());
            }

            return routes;
        }
    }
}