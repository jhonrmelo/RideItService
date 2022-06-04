using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Route.UpdateSegments
{
    public class RouteSegment
    {
        public string _id { get; set; }
        public int AverageStreet { get; set; }
        public int AverageBikeLane { get; set; }
        public int AverageLight { get; set; }
    }
}