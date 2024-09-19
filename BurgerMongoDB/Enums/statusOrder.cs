using System.Text.Json.Serialization;

namespace BurgerMongoDB.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum statusOrder
    {
        Atendimento,
        Producao,
        Finalizado
    }
}
