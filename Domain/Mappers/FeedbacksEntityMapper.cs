using Domain.Dto;
using Domain.Entity;

using System.Collections.Generic;

namespace Domain.Mappers
{
    public static class FeedbacksEntityMapper
    {
        public static IEnumerable<FeedbackDto> MapToDto(this IEnumerable<FeedbackEntity> feedbacks)
        {
            foreach (var feedback in feedbacks)
            {
                yield return new FeedbackDto()
                {
                    BikeLaneRating = feedback.BikeLaneRating,
                    Id = feedback.Id,
                    LightRating = feedback.LightRating,
                    StreetRating = feedback.StreetRating,
                    UserId = feedback.UserId
                };
            }
        }
    }
}