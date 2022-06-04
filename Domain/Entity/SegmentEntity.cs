using System.Collections.Generic;
using System.Linq;

namespace Domain.Entity
{
    public class SegmentEntity
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
        public List<FeedbackEntity> Feedbacks { get; set; }
        public bool IsBikeLane { get; set; }
        public List<List<double>> Coordinates { get; set; }

        private void CalculateAverageAll()
        {
            AverageAll = (AverageStreet + AverageLight + AverageBikeLane) / 3;
        }

        public void ProcessAverage()
        {
            var countBikelane = Feedbacks.Count(feedback => feedback.BikeLaneRating != null);
            var countLight = Feedbacks.Count(feedback => feedback.LightRating != null);
            var countStreet = Feedbacks.Count(feedback => feedback.StreetRating != null);

            int sumBikeLane = 0, sumLight = 0, sumStreet = 0;

            foreach (var feedback in Feedbacks)
            {
                if (feedback.BikeLaneRating != null)
                    sumBikeLane += (int)feedback.BikeLaneRating;
                if (feedback.LightRating != null)
                    sumLight += (int)feedback.LightRating;
                if (feedback.StreetRating != null)
                    sumStreet += (int)feedback.StreetRating;
            }

            AverageBikeLane = sumBikeLane / countBikelane;
            AverageLight = sumLight / countLight;
            AverageStreet = sumStreet / countStreet;
            this.CalculateAverageAll();
        }
    }
}