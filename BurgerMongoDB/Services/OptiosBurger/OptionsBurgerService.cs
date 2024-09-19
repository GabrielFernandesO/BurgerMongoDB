using BurgerMongoDB.DBContext;
using BurgerMongoDB.Models;
using MongoDB.Driver;
using System.Runtime.InteropServices;

namespace BurgerMongoDB.Services.OptiosBurger
{
    public class optionsBurgerService : IOptionsBurgerService
    {
        private readonly IMongoCollection<optionsBurgerModel> _burgerOptions;

        public optionsBurgerService(IDatabase settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.Database);
            _burgerOptions = database.GetCollection<optionsBurgerModel>("burgerOptions");
        }

        public async Task<BurgerResponse<List<optionsBurgerModel>>> createBurger(optionsBurgerModel newBurgerOption)
        {
            BurgerResponse<List<optionsBurgerModel>> burgerResponse = new BurgerResponse<List<optionsBurgerModel>>();

            if(newBurgerOption == null) {
                burgerResponse.flag = false;
                burgerResponse.message = "Data not found";
                burgerResponse.data = null;

                return burgerResponse;
            }

            await _burgerOptions.InsertOneAsync(newBurgerOption);

            burgerResponse.data = _burgerOptions.Find(user => true).ToList();
            burgerResponse.message = "Op Created";
            burgerResponse.flag = true;

            return burgerResponse;
        }

        public async Task<BurgerResponse<List<optionsBurgerModel>>> deleteBurger(string id)
        {
            BurgerResponse<List<optionsBurgerModel>> burgerResponse = new BurgerResponse<List<optionsBurgerModel>>();

            var getOpDelete = _burgerOptions.Find(burger => burger.id == id).FirstOrDefault();

            if(getOpDelete == null)
            {
                burgerResponse.flag = false;
                burgerResponse.message = "Op not found";
                burgerResponse.data = null;

                return burgerResponse;
            }

            await _burgerOptions.DeleteOneAsync(burger => burger.id == id);

            burgerResponse.data = _burgerOptions.Find(user => true).ToList();
            burgerResponse.message = "Op Deleted";
            burgerResponse.flag = true;

            return burgerResponse;
        }

        public async Task<BurgerResponse<List<optionsBurgerModel>>> editBurger(optionsBurgerModel editBurgerOption)
        {
            BurgerResponse<List<optionsBurgerModel>> burgerResponse = new BurgerResponse<List<optionsBurgerModel>>();

            var getOpDelete = _burgerOptions.Find(burger => burger.id == editBurgerOption.id).FirstOrDefault();

            if (getOpDelete == null)
            {
                burgerResponse.flag = false;
                burgerResponse.message = "Op not found";
                burgerResponse.data = null;

                return burgerResponse;
            }

            await _burgerOptions.ReplaceOneAsync(burgerOP => burgerOP.id == editBurgerOption.id, editBurgerOption);

            burgerResponse.data = _burgerOptions.Find(user => true).ToList();
            burgerResponse.message = "Op Updated";
            burgerResponse.flag = true;

            return burgerResponse;

        }

        public async Task<BurgerResponse<List<optionsBurgerModel>>> getBurgers()
        {

            BurgerResponse<List<optionsBurgerModel>> burgerResponse = new BurgerResponse<List<optionsBurgerModel>>();

            try
            {
                burgerResponse.data = _burgerOptions.Find(user => true).ToList();

                if(burgerResponse.data.Count == 0)
                {
                    burgerResponse.flag = false;
                    burgerResponse.message = "Data not found";
                    burgerResponse.data = null;

                    return burgerResponse;
                }


            }
            catch (Exception ex)
            {
                burgerResponse.message = ex.Message;
                burgerResponse.flag = false;

            }

            burgerResponse.flag = true;
            burgerResponse.message = "Data found";

            return burgerResponse;

        }
    }
}
