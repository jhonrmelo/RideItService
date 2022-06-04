using Application.UseCases.Point.GetAll;
using Application.UseCases.Point.GetById;

using Microsoft.AspNetCore.Mvc;

using System.Threading;
using System.Threading.Tasks;

using tcc_service.Api.Mappers.Point.GetAll;
using tcc_service.Api.Mappers.Point.GetById;

namespace tcc_service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private IGetByIdPointUseCase _getByIdPointUseCase;
        private IGetAllPointUseCase _getAllPointUseCase;

        public PointController(IGetByIdPointUseCase getByIdPointUseCase, IGetAllPointUseCase getAllPointUseCase)
        {
            _getByIdPointUseCase = getByIdPointUseCase;
            _getAllPointUseCase = getAllPointUseCase;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var input = new GetByIdPointUseCaseInput(id);

            var output = await _getByIdPointUseCase.ExecuteAsync(input, cancellationToken);

            if (!output.WasFound)
                return BadRequest("Não foi possivel encontrar o ponto de interesse.");

            return Ok(output.MapToResponse());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var output = await _getAllPointUseCase.ExecuteAsync(cancellationToken);

            if (!output.WasFound)
                return BadRequest("Não foi possivel encontrar o ponto de interesse.");

            return Ok(output.MapToResponse());
        }
    }
}