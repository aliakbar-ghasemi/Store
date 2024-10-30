using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Application.AccountingSoftware;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingSoftwareController(IMediator mediator) : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAccountingSoftwareData() 
        {
            var result = await mediator.Send(new GetAccountingSoftwareDataQuery());
            return Ok(result);
        }
    }
}
