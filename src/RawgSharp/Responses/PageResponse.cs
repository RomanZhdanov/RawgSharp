using RawgSharp.Models;
using System.Text.Json.Serialization;

namespace RawgSharp.Responses
{
    public class PageResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        [JsonPropertyName("results")]
        public IList<GameItem> Results { get; set; }
    }
}