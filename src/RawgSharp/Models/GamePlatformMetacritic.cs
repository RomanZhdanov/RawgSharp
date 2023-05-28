using System.Text.Json.Serialization;

namespace RawgSharp.Models
{
    public class GamePlatformMetacritic
    {
        [JsonPropertyName("metascore")]
        public double? Metascore { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
