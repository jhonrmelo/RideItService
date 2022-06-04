using System.Collections.Generic;

namespace Domain.Dto
{
    public class PointDto
    {
        public string _key { get; set; }
        public string _id { get; set; }
        public string _rev { get; set; }
        public string Name { get; set; }
        public List<double> Coordinates { get; set; }
    }
}