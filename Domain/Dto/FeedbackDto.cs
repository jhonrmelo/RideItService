using System;

namespace Domain.Dto
{
    public class FeedbackDto
    {
        public Guid Id { get; set; }
        public int? StreetRating { get; set; }
        public int? LightRating { get; set; }
        public int? BikeLaneRating { get; set; }
        public int UserId { get; set; }
    }
}