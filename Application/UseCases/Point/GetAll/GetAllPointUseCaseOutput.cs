using Domain.Entity;

using System.Collections.Generic;

namespace Application.UseCases.Point.GetAll
{
    public class GetAllPointUseCaseOutput
    {
        public bool WasFound { get; set; }
        public IEnumerable<PointEntity> Points { get; set; }

        public static GetAllPointUseCaseOutput Ok(IEnumerable<PointEntity> points)
        {
            return new GetAllPointUseCaseOutput()
            {
                Points = points,
                WasFound = true
            };
        }

        public static GetAllPointUseCaseOutput Fail() => new GetAllPointUseCaseOutput() { WasFound = false };
    }
}