using Domain.Dto;
using Domain.Entity;
using Domain.Entity.Mongo;

using System;
using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class FeedbacksDtoMapper
    {
        public static FeedbackDocument MapToDocument(this FeedbackDto feedbackDto)
            => new FeedbackDocument()
            {
                BikeLaneRating = feedbackDto.BikeLaneRating,
                Id = feedbackDto.Id,
                LightRating = feedbackDto.LightRating,
                StreetRating = feedbackDto.StreetRating
            };

        public static IEnumerable<FeedbackDocument> MapToDocument(this IEnumerable<FeedbackDto> feedbackDtos)
        {
            foreach (var feedback in feedbackDtos)
                yield return feedback.MapToDocument();
        }

        public static FeedbackEntity MapToEntity(this FeedbackDto feedbackDto, bool generateId = true)
            => new FeedbackEntity()
            {
                BikeLaneRating = feedbackDto.BikeLaneRating,
                Id = generateId ? Guid.NewGuid() : feedbackDto.Id,
                LightRating = feedbackDto.LightRating,
                StreetRating = feedbackDto.StreetRating
            };

        public static IEnumerable<FeedbackEntity> MapToEntity(this IEnumerable<FeedbackDto> feedbackDtos)
        {
            foreach (var feedback in feedbackDtos)
                yield return feedback.MapToEntity();
        }
    }
}