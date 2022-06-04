using Domain.Dto;
using Domain.Entity.Mongo;

using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class PointDtoMapper
    {
        public static PointDocument MapToDocument(this PointDto pointDto)
            => new PointDocument()
            {
                Coordinates = pointDto.Coordinates,
                Name = pointDto.Name,
                _id = pointDto._id,
                _key = pointDto._key,
                _rev = pointDto._rev
            };

        public static IEnumerable<PointDocument> MapToDocument(this IEnumerable<PointDto> pointsDto)
        {
            var points = new List<PointDocument>();
            foreach (var item in pointsDto)
            {
                points.Add(item.MapToDocument());
            }
            return points;
        }
    }
}