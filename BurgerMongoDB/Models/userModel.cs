using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BurgerMongoDB.Models
{
    [BsonIgnoreExtraElements]
    public class userModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string name { get; set; } = string.Empty;

        [BsonElement("email")]
        public string email { get; set; } = string.Empty;

        [BsonElement("password")]
        public string password { get; set; } = string.Empty;
        [BsonElement("isAdmin")]
        public bool isAdmin { get; set; } = false;

        [BsonElement("creation_time")]
        public DateTime creation_time { get; set; } = DateTime.Now.ToLocalTime();
    }
}
