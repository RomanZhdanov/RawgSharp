using System.Text.Json.Serialization;

namespace RawgSharp.Models
{
    public class GamePlatform
    {
        [JsonPropertyName("platform")]
        public Platform Platform { get; set; }

        [JsonPropertyName("released_at")]
        public string ReleasedAt { get; set; }
    }
}
