using Microsoft.AspNetCore.Mvc;
using ProjetoCripto.API.src.Interfaces;
using ProjetoCripto.API.src.Models.Requests;

namespace ProjetoCripto.API.src.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost()]
        public async Task<IActionResult> RegisterUser(RegisterUserRequest request)
        {
            var result = await _userService.RegisterUser(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> LoginUser([FromQuery]LoginUserRequest request)
        {
            var result = await _userService.LoginUser(request);
            return Ok(result);
        }
    }
}
