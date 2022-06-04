using MongoDB.Bson.Serialization.Attributes;

using System;
using System.Collections.Generic;

namespace Domain.Entity.Mongo
{
    public class RouteCollection
    {
        [BsonId]
        public Guid Id { get; set; }

        public int UserId { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;

        public IEnumerable<PointDocument> Points { get; set; }
        public IEnumerable<SegmentDocument> Segments { get; set; }
    }

    public class PointDocument
    {
        public string _key { get; set; }

        [BsonId]
        public string _id { get; set; }

        public string _rev { get; set; }
        public string Name { get; set; }
        public List<double> Coordinates { get; set; }
    }

    public class SegmentDocument
    {
        public string _key { get; set; }

        [BsonId]
        public string _id { get; set; }

        public string _from { get; set; }
        public string _to { get; set; }
        public string _rev { get; set; }
        public double AverageStreet { get; set; }
        public double AverageBikeLane { get; set; }
        public double AverageLight { get; set; }
        public double AverageAll { get; set; }
        public List<FeedbackDocument> Feedbacks { get; set; }
        public bool IsBikeLane { get; set; }
        public List<List<double>> Coordinates { get; set; }
    }

    public class FeedbackDocument
    {
        [BsonId]
        public Guid Id { get; set; }

        public int? StreetRating { get; set; }
        public int? LightRating { get; set; }
        public int? BikeLaneRating { get; set; }
    }
}