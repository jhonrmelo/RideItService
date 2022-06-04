using Application.UseCases.User.Create;
using Application.UseCases.User.Delete;
using Application.UseCases.User.GetAll;
using Application.UseCases.User.GetById;
using Application.UseCases.User.ImageDownload;
using Application.UseCases.User.ImageUpload;
using Application.UseCases.User.Update;

using Contracts.User.Create;
using Contracts.User.Update;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Threading;
using System.Threading.Tasks;

using tcc_service.Api.Mappers.User.CreateUser;
using tcc_service.Api.Mappers.User.GetAllUser;
using tcc_service.Api.Mappers.User.GetByIdUser;
using tcc_service.Api.Mappers.User.UpdateUser;

namespace tcc_service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ICreateUserUseCase _createUserUseCase;
        private readonly IDeleteUserUseCase _deleteUserUseCase;
        private readonly IGetAllUserUseCase _getAllUserUseCase;
        private readonly IGetByIdUserUseCase _getByIdUserUseCase;
        private readonly IUpdateUserUseCase _updateUserUseCase;
        private readonly IUserImageDownloadUseCase _userImageDownloadUseCase;

        private readonly IUserImageUploadUseCase _userImageUploadUseCase;

        public UserController(
            ICreateUserUseCase createUserUseCase,
            IDeleteUserUseCase deleteUserUseCase,
            IGetAllUserUseCase getAllUserUseCase,
            IGetByIdUserUseCase getByIdUserUseCase,
            IUpdateUserUseCase updateUserUseCase,
            IUserImageUploadUseCase userImageUploadUseCase,
            IUserImageDownloadUseCase userImageDownloadUseCase
            )
        {
            _createUserUseCase = createUserUseCase;
            _deleteUserUseCase = deleteUserUseCase;
            _getAllUserUseCase = getAllUserUseCase;
            _getByIdUserUseCase = getByIdUserUseCase;
            _updateUserUseCase = updateUserUseCase;
            _userImageUploadUseCase = userImageUploadUseCase;
            _userImageDownloadUseCase = userImageDownloadUseCase;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var input = new GetByIdUserUseCaseInput()
            {
                Id = id
            };

            var output = await _getByIdUserUseCase.ExecuteAsync(input, cancellationToken);

            if (output.HasExecutedWithoutError)
                return Ok(output.MapToResponse());

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var output = await _getAllUserUseCase.ExecuteAsync(cancellationToken);

            if (output.Returned)
                return Ok(output.MapToResponse());

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken cancellationToken)
        {
            var input = request.MapToInput();

            var output = await _createUserUseCase.ExecuteAsync(input, cancellationToken);

            if (output.Inserted)
                return Accepted(output.MapToResponse());

            return Conflict("Usuário já existe em nossa base de dados.");
        }

        [HttpPost("{userId}/Image/Upload")]
        [Authorize]
        public async Task<IActionResult> Upload([FromForm] IFormFile image, [FromRoute] int userId, CancellationToken cancellationToken)
        {
            if (image is null)
                return BadRequest();

            var input = new UserImageUploadUseCaseInput(image, userId);

            await _userImageUploadUseCase.ExecuteAsync(input, cancellationToken);
            return Ok();
        }

        [HttpGet("{userId}/Image/Download")]
        [Authorize]
        public async Task<IActionResult> GetImage([FromRoute] int userId, CancellationToken cancellationToken)
        {
            if (userId == 0)
                return BadRequest();

            var input = new UserImageDownloadUseCaseInput(userId);

            var output = await _userImageDownloadUseCase.ExecuteAsync(input, cancellationToken);

            return output;
        }

        [HttpPatch]
        [Authorize]
        public async Task<IActionResult> Update([FromBody] UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var input = request.MapToInput();

            var output = await _updateUserUseCase.ExecuteAsync(input, cancellationToken);

            if (output.Updated)
                return Ok(output.MapToResponse());

            return BadRequest();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }
    }
}