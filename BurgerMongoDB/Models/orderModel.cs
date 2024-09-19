using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using BurgerMongoDB.Enums;

namespace BurgerMongoDB.Models
{
    public class orderModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("bread")]
        public string bread { get; set; }

        [BsonElement("meat")]
        public string meat { get; set; }

        [BsonElement("salad")]
        public string salad { get; set; }

        [BsonElement("sauce")]
        public string sauce { get; set; }

        [BsonElement("status")]
        public statusOrder status { get; set; } = statusOrder.Atendimento;

        [BsonElement("creation_time")]
        public DateTime creation_time { get; set; } = DateTime.Now.ToLocalTime();

        [BsonElement("updated_time")]
        public DateTime updated_time { get; set; } = DateTime.Now.ToLocalTime();
    }
}
