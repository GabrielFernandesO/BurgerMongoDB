using BurgerMongoDB.Models;
using BurgerMongoDB.Services;
using BurgerMongoDB.Services.OptiosBurger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsBurgerController : ControllerBase
    {

        private readonly IOptionsBurgerService _opBurger;

        public OptionsBurgerController(IOptionsBurgerService opBurger)
        {
            _opBurger = opBurger;
        }

        [HttpGet]
        public async Task<ActionResult<BurgerResponse<List<optionsBurgerModel>>>> getBurgers()
        {
            return Ok(await _opBurger.getBurgers());
        }

        [HttpPost]
        public async Task<ActionResult<BurgerResponse<List<optionsBurgerModel>>>> createBurger(optionsBurgerModel newOpBurger)
        {
            return Ok(await _opBurger.createBurger(newOpBurger));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BurgerResponse<List<optionsBurgerModel>>>> deleteBurger(string id)
        {
            return Ok(await _opBurger.deleteBurger(id));
        }

        [HttpPut]
        public async Task<ActionResult<BurgerResponse<List<optionsBurgerModel>>>> updateBurger(optionsBurgerModel newOpBurger)
        {
            return Ok(await _opBurger.editBurger(newOpBurger));
        }

    }
}
