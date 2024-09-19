using BurgerMongoDB.DTOs;
using BurgerMongoDB.Models;
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
            return Ok(await _userService.Login(loginDTO));
        }


        [HttpPost("register")]
        public async Task<ActionResult<loginResponse>> Register(registerDTO registerDTO)
        {
            return Ok(await _userService.Register(registerDTO));
        }

        //[HttpGet("{id}")]
        //public ActionResult<userModel> Get(string id)
        //{
        //    var user = _userService.Get(id);

        //    if(user == null)
        //    {
        //        return NotFound("Nada encontrado");
        //    }

        //    return Ok(user);
        //}

        //[HttpPost]
        //public ActionResult Post([FromBody] userModel user)
        //{
        //    _userService.create(user);

        //    return CreatedAtAction(nameof(Get), new { id = user.id }, user);
        //}

        //[HttpPut]
        //public ActionResult Put(string id, [FromBody] userModel user)
        //{
        //    var existUser = _userService.Get(id);

        //    if(existUser == null)
        //    {
        //        return NotFound("Id nao existe");
        //    }

        //    _userService.Update(id, user);

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public ActionResult Delete(string id)
        //{
        //    var user = _userService?.Get(id);

        //    if(user == null)
        //    {
        //        return NotFound("User nao encotnrado");
        //    }

        //    _userService.Remove(user.id);

        //    return Ok("User deletado");

        //}

    }
}
