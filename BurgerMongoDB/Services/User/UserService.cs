using BurgerMongoDB.DBContext;
using BurgerMongoDB.DTOs;
using BurgerMongoDB.Models;
using MongoDB.Driver;

namespace BurgerMongoDB.Services.User
{
    public class userService : IUserService
    {

        //Interface mongocollection and objects collections of userModel
        private readonly IMongoCollection<userModel> _users;

        public userService(IDatabase settings, IMongoClient mongoClient)
        {
            //database
            var database = mongoClient.GetDatabase(settings.Database);
            //specific table of database (collection fromd db)
            _users = database.GetCollection<userModel>(settings.CollectionDB);
        }



        public async Task<loginResponse> Login(loginDTO loginData)
        {
            var user = await _users.Find(user => user.email == loginData.email).FirstOrDefaultAsync();

            if (user == null)
            {
                return new loginResponse(false, "User not Found");
            }

            bool checkPassword = BCrypt.Net.BCrypt.Verify(loginData.password, user.password);

            if (checkPassword)
            {
                var dataUser = new userLoggedDTO
                {
                    name = user.name,
                    email = user.email,
                    isAdmin = user.isAdmin,
                };

                return new loginResponse(true, "Login success", dataUser);
            }

            return new loginResponse(false, "Invalid Credentials");
        }

        public async Task<registerResponse> Register(registerDTO registerData)
        {
            var user = await _users.Find(user => user.email == registerData.email).FirstOrDefaultAsync();

            if (user != null)
            {
                return new registerResponse(false, "User exists");
            }


            var newUser = new userModel
            {
                name = registerData.name,
                email = registerData.email,
                password = BCrypt.Net.BCrypt.HashPassword(registerData.password)
            };

            await _users.InsertOneAsync(newUser);

            return new registerResponse(true, "User registered successfully");

        }
    }
}
