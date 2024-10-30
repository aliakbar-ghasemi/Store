using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Application.User.Commands;
using Store.Application.User.Queries;
using Store.Domain.Entities;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IMediator mediator) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddUserAsync([FromBody] UserEntity userEntity)
        {
            var result = await mediator.Send(new AddUserCommand(userEntity));
            return Ok(result);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var result = await mediator.Send(new GetAllUserQuery());
            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserByIdAsync([FromRoute] Guid userId)
        {
            var result = await mediator.Send(new GetUserByIdQuery(userId));
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateUserAsync([FromBody] UserEntity userEntity)
        {
            var result = await mediator.Send(new UpdateUserCommand(userEntity));
            return Ok(result);
        }

        [HttpDelete("delete/{userId}")]
        public async Task<IActionResult> DeleteUserAsync([FromRoute] Guid userId)
        {
            var result = await mediator.Send(new DeleteUserCommand(userId));
            return Ok(result);
        }
    }
}
