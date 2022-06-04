using Application.UseCases.Route.Get;
using Application.UseCases.Route.GetByUserId;
using Application.UseCases.Route.Insert;
using Application.UseCases.Route.UpdateRouteSegments;

using Contracts.Route.UpdateSegments;

using Domain.Dto.Mongo;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Threading;
using System.Threading.Tasks;

using tcc_service.Api.Mappers.Route.Get;

namespace tcc_service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private IGetRouteUseCase getRouteUseCase;
        private IInsertRouteUseCase insertRouteUseCase;
        private IGetRouteByUserIdUseCase getRouteByUserIdUseCase;
        private IUpdateRouteSegmentsUseCase updateRouteSegmentsUseCase;

        public RouteController(
            IGetRouteUseCase getRouteUseCase,
            IInsertRouteUseCase insertRouteUseCase,
            IGetRouteByUserIdUseCase getRouteByUserIdUseCase,
            IUpdateRouteSegmentsUseCase updateRouteSegmentsUseCase)
        {
            this.getRouteUseCase = getRouteUseCase;
            this.insertRouteUseCase = insertRouteUseCase;
            this.getRouteByUserIdUseCase = getRouteByUserIdUseCase;
            this.updateRouteSegmentsUseCase = updateRouteSegmentsUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int from, [FromQuery] int to, [FromQuery] string preference, CancellationToken cancellationToken)
        {
            var result = await this.getRouteUseCase.ExecuteAsync(new GetRouteUseCaseInput(from, to, preference), cancellationToken);

            if (!result.WasFound)
                return NotFound();

            return Ok(result.MapToResponse());
        }

        [HttpPost("User")]
        public async Task<IActionResult> Post([FromBody] RouteDto userRoutesDto, CancellationToken cancellation)
        {
            await this.insertRouteUseCase.ExecuteAsync(new InsertRouteUseCaseInput() { Route = userRoutesDto }, cancellation);

            return Ok();
        }

        [HttpGet("User/{userId}")]
        public async Task<IActionResult> GetByUserId(int userId, CancellationToken cancellationToken)
        {
            var response = await this.getRouteByUserIdUseCase.ExecuteAsync(new GetRouteByUserIdUseCaseInput { UserId = userId }, cancellationToken);

            if (!response.HasValue)
                return NoContent();

            return Ok(response.MapToResponse());
        }

        [HttpPut("{routeId}/Segments")]
        public async Task<IActionResult> UpdateRouteSegments(Guid routeId, [FromBody] UpdateRouteSegmentsRequest request, CancellationToken cancellationToken)
        {
            var input = new UpdateRouteSegmentsUseCaseInput() { RouteID = routeId, UserRouteSegments = request.RouteSegments };

            await this.updateRouteSegmentsUseCase.ExecuteAsync(input, cancellationToken);

            return Ok();
        }
    }
}