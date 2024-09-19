namespace BurgerMongoDB.DTOs
{
    public record loginResponse(bool flag, string message = null!, userLoggedDTO user = null!);

}
