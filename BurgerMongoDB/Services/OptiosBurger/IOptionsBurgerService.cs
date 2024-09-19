using BurgerMongoDB.Models;

namespace BurgerMongoDB.Services.OptiosBurger
{
    public interface IOptionsBurgerService
    {
        Task<BurgerResponse<List<optionsBurgerModel>>> getBurgers();

        Task<BurgerResponse<List<optionsBurgerModel>>> createBurger(optionsBurgerModel newBurgerOption);

        Task<BurgerResponse<List<optionsBurgerModel>>> editBurger(optionsBurgerModel editBurgerOption);

        Task<BurgerResponse<List<optionsBurgerModel>>> deleteBurger(string id);
    }
}
