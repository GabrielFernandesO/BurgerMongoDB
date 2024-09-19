using BurgerAPI.Services.OrderService;
using BurgerMongoDB.Models;
using BurgerMongoDB.Services.OptiosBurger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrder _order;
        public OrderController(IOrder order)
        {
            _order = order;
        }

        [HttpGet]
        public async Task<ActionResult<OrderResponse<List<orderModel>>>> getOrders()
        {
            return Ok(await _order.getOrders());
        }

        [HttpPost]
        public async Task<ActionResult<OrderResponse<List<orderModel>>>> createOrder(orderModel newOrder)
        {
            return Ok(await _order.createOrder(newOrder));
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<OrderResponse<orderModel>>> getOrders(string name)
        {
            return Ok(await _order.getOrderByName(name));
        }

        [HttpPut("order")]
        public async Task<ActionResult<OrderResponse<List<orderModel>>>> editOrder(orderModel newOrder)
        {
            return Ok(await _order.editOrder(newOrder));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderResponse<List<orderModel>>>> deleteOrder(string id)
        {
            return Ok(await _order.deleteOrder(id));
        }
    }
}
