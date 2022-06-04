using Domain.Dto;
using Domain.Entity;

using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class SegmentEntityMapper
    {
        public static SegmentDto MapToDto(this SegmentEntity segmentEntity)
            => new SegmentDto()
            {
                AverageAll = segmentEntity.AverageAll,
                AverageBikeLane = segmentEntity.AverageBikeLane,
                AverageLight = segmentEntity.AverageLight,
                AverageStreet = segmentEntity.AverageStreet,
                Coordinates = segmentEntity.Coordinates,
                Feedbacks = segmentEntity.Feedbacks.MapToDto(),
                IsBikeLane = segmentEntity.IsBikeLane,
                _from = segmentEntity._from,
                _id = segmentEntity._id,
                _key = segmentEntity._key,
                _rev = segmentEntity._rev,
                _to = segmentEntity._to
            };

        public static IEnumerable<SegmentDto> MapToDto(this IEnumerable<SegmentEntity> segmentsEntity)
        {
            foreach (var segment in segmentsEntity)
            {
                yield return segment.MapToDto();
            }
        }
    }
}