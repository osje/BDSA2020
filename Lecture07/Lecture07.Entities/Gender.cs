using System.Text.Json.Serialization;

namespace Lecture07.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Female,
        Male,
        Other
    }
}
