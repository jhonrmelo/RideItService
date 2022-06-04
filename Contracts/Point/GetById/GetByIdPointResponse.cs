using Domain.Dto;

namespace Contracts.Point.GetById
{
    public class GetByIdPointResponse
    {
        public PointDto PointDto { get; set; }
        public bool WasFound { get; set; }
    }
}