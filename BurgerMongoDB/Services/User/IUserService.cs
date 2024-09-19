using BurgerMongoDB.DTOs;
using BurgerMongoDB.Models;

namespace BurgerMongoDB.Services.User
{
    public interface IUserService
    {

        Task<loginResponse> Login(loginDTO loginData);
        Task<registerResponse> Register(registerDTO registerData);

    }
}
