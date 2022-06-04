using Domain.Dto.Mongo;
using Domain.Entity.Mongo;

using System;
using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class UserRoutesDtoMapper
    {
        public static RouteCollection MapToCollection(this RouteDto userRoutesDto)
            => new RouteCollection()
            {
                Id = Guid.NewGuid(),
                UserId = userRoutesDto.UserId,
                Points = userRoutesDto.Points.MapToDocument(),
                Segments = userRoutesDto.Segments.MapToDocument(),
            };
    }
}