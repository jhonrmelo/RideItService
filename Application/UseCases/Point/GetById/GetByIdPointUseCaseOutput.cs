using Domain.Entity;

namespace Application.UseCases.Point.GetById
{
    public class GetByIdPointUseCaseOutput
    {
        public bool WasFound { get; set; }
        public PointEntity Point { get; set; }

        public static GetByIdPointUseCaseOutput Ok(PointEntity point)
        {
            return new GetByIdPointUseCaseOutput()
            {
                Point = point,
                WasFound = true
            };
        }

        public static GetByIdPointUseCaseOutput Fail() => new GetByIdPointUseCaseOutput();
    }
}