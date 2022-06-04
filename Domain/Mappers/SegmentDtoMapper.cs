using Domain.Dto;
using Domain.Entity;
using Domain.Entity.Mongo;

using System.Collections.Generic;
using System.Linq;

namespace Domain.Mappers
{
    public static class SegmentDtoMapper
    {
        public static SegmentDocument MapToDocument(this SegmentDto segmentDto)
            => new SegmentDocument()
            {
                _to = segmentDto._to,
                _rev = segmentDto._rev,
                _key = segmentDto._key,
                AverageAll = segmentDto.AverageAll,
                AverageBikeLane = segmentDto.AverageBikeLane,
                AverageLight = segmentDto.AverageLight,
                AverageStreet = segmentDto.AverageStreet,
                Coordinates = segmentDto.Coordinates,
                Feedbacks = segmentDto.Feedbacks.MapToDocument().ToList(),
                IsBikeLane = segmentDto.IsBikeLane,
                _from = segmentDto._from,
                _id = segmentDto._id
            };

        public static SegmentEntity MapToEntity(this SegmentDto segmentDto)
            => new SegmentEntity()
            {
                _to = segmentDto._to,
                _rev = segmentDto._rev,
                _key = segmentDto._key,
                AverageAll = segmentDto.AverageAll,
                AverageBikeLane = segmentDto.AverageBikeLane,
                AverageLight = segmentDto.AverageLight,
                AverageStreet = segmentDto.AverageStreet,
                Coordinates = segmentDto.Coordinates,
                Feedbacks = segmentDto.Feedbacks.MapToEntity().ToList(),
                IsBikeLane = segmentDto.IsBikeLane,
                _from = segmentDto._from,
                _id = segmentDto._id
            };

        public static IEnumerable<SegmentDocument> MapToDocument(this IEnumerable<SegmentDto> segmentsDto)
        {
            var segments = new List<SegmentDocument>();
            foreach (var segment in segmentsDto)
            {
                segments.Add(segment.MapToDocument());
            }

            return segments;
        }

        public static IEnumerable<SegmentEntity> MapToEntity(this IEnumerable<SegmentDto> segmentsDto)
        {
            var segments = new List<SegmentEntity>();
            foreach (var segment in segmentsDto)
            {
                segments.Add(segment.MapToEntity());
            }

            return segments;
        }
    }
}