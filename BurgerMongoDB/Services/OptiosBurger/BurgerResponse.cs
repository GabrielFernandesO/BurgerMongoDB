namespace BurgerMongoDB.Services.OptiosBurger
{
    public class BurgerResponse<T>
    {
        public T? data { get; set; }

        public string message { get; set; }
        public bool flag { get; set; } = true;
    }
}
