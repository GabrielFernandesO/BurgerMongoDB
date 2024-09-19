using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BurgerMongoDB.Models
{
    public class optionsBurgerModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; } = string.Empty;

        [BsonElement("bread")]
        public string bread { get; set; }

        [BsonElement("meat")]
        public string meat { get; set; }

        [BsonElement("salad")]
        public string salad { get; set; }

        [BsonElement("sauce")]
        public string sauce { get; set; }
    }
}
