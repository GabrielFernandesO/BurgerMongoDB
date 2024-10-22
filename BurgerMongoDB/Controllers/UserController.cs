using BurgerMongoDB.DTOs;
using BurgerMongoDB.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<loginResponse>> Login(loginDTO loginDTO)
        {
            var response = await _userService.Login(loginDTO);

            if (response.flag)
            {
                return Ok(response); // 200 OK
            }
            else if (response.message == "User not Found")
            {
                return NotFound(response); // 404 Not Found
            }
            else
            {
                return Unauthorized(response); // 401 Unauthorized
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult<registerResponse>> Register(registerDTO registerDTO)
        {
            var response = await _userService.Register(registerDTO);

            if (response.flag)
            {
                return CreatedAtAction(nameof(Login), new { }, response); // 201 Created
            }
            else if (response.message == "User exists")
            {
                return Conflict(response); // 409 Conflict
            }

            return BadRequest(response); // 400 Bad Request 
        }
    }
}
