using Application.UseCases.Authenticate;

using Contracts.Login.Authenticate;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Threading;
using System.Threading.Tasks;

using tcc_service.Api.Mappers.Authenticate;

namespace tcc_service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IAuthenticateUseCase _authenticateUse;

        public LoginController(IAuthenticateUseCase authenticateUseCase)
        {
            _authenticateUse = authenticateUseCase;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest request, CancellationToken cancellationToken)
        {
            var input = new AuthenticateInput(request.Email, request.Password);

            var output = await _authenticateUse.ExecuteAsync(input, cancellationToken);

            if (!output.IsAuthenticated)
            {
                return BadRequest("O usuário não pôde ser autenticado");
            }

            return Ok(output.MapToResponse());
        }
    }
}