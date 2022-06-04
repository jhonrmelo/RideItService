using Application.UseCases.Segment.GetAll;
using Application.UseCases.Segment.GetById;
using Application.UseCases.Segment.Update;

using Contracts.Segment.Update;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

using tcc_service.Api.Mappers.Segment.GetAll;
using tcc_service.Api.Mappers.Segment.GetById;

namespace tcc_service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SegmentController : Controller
    {
        private readonly IGetByIdSegmentUseCase _getByIdSegmentUseCase;
        private readonly IUpdateSegmentUseCase _updateSegmentUseCase;
        private readonly IGetAllSegmentUseCase _getAllSegmentUseCase;

        public SegmentController(IGetByIdSegmentUseCase getByIdSegmentUseCase,
                                 IGetAllSegmentUseCase getAllSegmentUseCase,
                                 IUpdateSegmentUseCase updateSegmentUseCase)
        {
            _getByIdSegmentUseCase = getByIdSegmentUseCase;
            _getAllSegmentUseCase = getAllSegmentUseCase;
            _updateSegmentUseCase = updateSegmentUseCase;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var input = new GetByIdSegmentUseCaseInput(id);
            var output = await _getByIdSegmentUseCase.ExecuteAsync(input, cancellationToken);

            if (!output.WasFound)
                return BadRequest("Não foi possivel encontrar o segmento.");

            return Ok(output.MapToResponse());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var output = await _getAllSegmentUseCase.ExecuteAsync(cancellationToken);

            if (!output.WasFound)
                return BadRequest("Não foi possivel encontrar o segmento.");

            return Ok(output.MapToResponse());
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSegmentRequest request, CancellationToken cancellationToken)
        {
            var userIdClaim = User?.Claims?.Where(a => a.Type == ClaimTypes.NameIdentifier)?.FirstOrDefault().Value;

            int userId = userIdClaim is null ? 0 : Convert.ToInt32(userIdClaim);

            var input = new UpdateSegmentUseCaseInput() { Segments = request.Segment, UserId = userId };

            await _updateSegmentUseCase.ExecuteAsync(input, cancellationToken);

            return Ok();
        }
    }
}