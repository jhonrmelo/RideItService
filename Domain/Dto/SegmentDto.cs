using System.Collections.Generic;
using System.Linq;

namespace Domain.Dto
{
    public class SegmentDto
    {
        public string _key { get; set; }
        public string _id { get; set; }
        public string _from { get; set; }
        public string _to { get; set; }
        public string _rev { get; set; }
        public double AverageStreet { get; set; }
        public double AverageBikeLane { get; set; }
        public double AverageLight { get; set; }
        public double AverageAll { get; set; }
        public IEnumerable<FeedbackDto> Feedbacks { get; set; }
        public bool IsBikeLane { get; set; }
        public List<List<double>> Coordinates { get; set; }

        public void ClearRatings()
        {
            Feedbacks = Enumerable.Empty<FeedbackDto>();
            AverageAll = 0;
            AverageBikeLane = 0;
            AverageLight = 0;
            AverageStreet = 0;
        }
    }
}