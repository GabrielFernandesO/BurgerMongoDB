using System.Reflection.Metadata.Ecma335;

namespace BurgerAPI.Services.OrderService
{
    public class OrderResponse<T>
    {
        public T? data { get; set; }
        public string message { get; set; } = string.Empty;
        public bool flag { get; set; } = false;
    }
}
