

using BurgerMongoDB.DBContext;
using BurgerMongoDB.Models;
using BurgerMongoDB.Services.OptiosBurger;
using MongoDB.Driver;

namespace BurgerAPI.Services.OrderService
{
    public class OrderService : IOrder
    {
        private readonly IMongoCollection<orderModel> _orders;

        public OrderService(IDatabase settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.Database);
            _orders = database.GetCollection<orderModel>("orders");
        }

        public async Task<OrderResponse<List<orderModel>>> getOrders()
        {
            OrderResponse<List<orderModel>> orderResponse = new OrderResponse<List<orderModel>>();

            var getOrder = await _orders.Find(user => true).ToListAsync();

            try
            {
                if (getOrder.Count == 0)
                {
                    orderResponse.data = null;
                    orderResponse.message = "Data not found";
                    orderResponse.flag = false;

                    return orderResponse;
                }

                orderResponse.data = getOrder;
                orderResponse.message = "Data found!";
                orderResponse.flag = true;

                return orderResponse;

            }
            catch (Exception ex)
            {
                orderResponse.flag = false;
                orderResponse.message = ex.Message;

                return orderResponse;
            }
        }

     
        public async Task<OrderResponse<List<orderModel>>> getOrderByName(string name)
        {
            OrderResponse<List<orderModel>> orderResponse = new OrderResponse<List<orderModel>>();

            List<orderModel> getOrderName = await _orders.Find(order => order.name == name).ToListAsync();

            if (getOrderName == null)
            {
                orderResponse.data = null;
                orderResponse.message = "Order not found";
                orderResponse.flag = false;

                return orderResponse;
            }

            orderResponse.data = getOrderName;
            orderResponse.message = "Order found!";
            orderResponse.flag = true;

            return orderResponse;
        }

        public async Task<OrderResponse<List<orderModel>>> createOrder(orderModel order)
        {
            OrderResponse<List<orderModel>> orderResponse = new OrderResponse<List<orderModel>>();

            try
            {
                if(order == null)
                {
                    orderResponse.data = null;
                    orderResponse.message = "Order null";
                    orderResponse.flag = false;

                    return orderResponse;
                }

                await _orders.InsertOneAsync(order);

                orderResponse.flag = true;
                orderResponse.data = _orders.Find(user => true).ToList();
                orderResponse.message = "Order created";

                return orderResponse;

            }
            catch (Exception ex)
            {
                orderResponse.flag = false;
                orderResponse.message = ex.Message;

                return orderResponse;
            }
        }

        public async Task<OrderResponse<List<orderModel>>> deleteOrder(string id)
        {

            OrderResponse<List<orderModel>> orderResponse = new OrderResponse<List<orderModel>>();

            var getOrderDelete = _orders.Find(order => order.id == id).FirstOrDefault();

            if (getOrderDelete == null)
            {
                orderResponse.flag = false;
                orderResponse.message = "Order not found";
                orderResponse.data = null;

                return orderResponse;
            }

            await _orders.DeleteOneAsync(order => order.id == id);

            orderResponse.data = _orders.Find(user => true).ToList();
            orderResponse.message = "Order deleted";
            orderResponse.flag = true;

            return orderResponse;
        }

        public async Task<OrderResponse<List<orderModel>>> editOrder(orderModel newOrder)
        {
            OrderResponse<List<orderModel>> orderResponse = new OrderResponse<List<orderModel>>();

            var getOrder = await _orders.Find(order => order.id == newOrder.id).FirstOrDefaultAsync();

            try
            {
                if (getOrder == null)
                {
                    orderResponse.flag = false;
                    orderResponse.message = "Order not found";
                    orderResponse.data = null;
                }

                newOrder.updated_time = DateTime.Now.ToLocalTime();

                await _orders.ReplaceOneAsync(order => order.id == newOrder.id, newOrder);

                orderResponse.flag = true;
                orderResponse.message = "Order updated";
                orderResponse.data = _orders.Find(user => true).ToList();

                return orderResponse;

            }
            catch (Exception ex )
            {

                orderResponse.flag = false;
                orderResponse.message = ex.Message;

                return orderResponse;
            }

   
        }
    }
}
