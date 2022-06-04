using Domain.Dto;
using Domain.Entity;

using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class PointEntityMapper
    {
        public static PointDto MapToDto(this PointEntity pointEntity)
            => new PointDto()
            {
                _id = pointEntity._id,
                Coordinates = pointEntity.Coordinates,
                Name = pointEntity.Name,
                _key = pointEntity._key,
                _rev = pointEntity._rev
            };

        public static IEnumerable<PointDto> MapToDto(this IEnumerable<PointEntity> pointsEnitity)
        {
            foreach (var point in pointsEnitity)
            {
                yield return point.MapToDto();
            }
        }
    }
}