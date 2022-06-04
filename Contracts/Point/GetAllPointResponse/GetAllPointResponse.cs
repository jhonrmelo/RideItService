using Domain.Dto;

using System.Collections.Generic;

namespace Contracts.Point.GetAllPointResponse
{
    public class GetAllPointResponse
    {
        public IEnumerable<PointDto> PointsDto { get; set; }
        public bool WasFound { get; set; }
    }
}