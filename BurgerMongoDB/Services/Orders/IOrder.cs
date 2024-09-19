using BurgerMongoDB.Models;

namespace BurgerAPI.Services.OrderService
{
    public interface IOrder
    {
        Task<OrderResponse<List<orderModel>>> getOrders();

        Task<OrderResponse<List<orderModel>>> getOrderByName(string name);

        Task<OrderResponse<List<orderModel>>> createOrder(orderModel order);

        Task<OrderResponse<List<orderModel>>> deleteOrder(string id);

        Task<OrderResponse<List<orderModel>>> editOrder(orderModel newOrder);

    }
}
