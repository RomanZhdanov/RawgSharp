﻿using System.Text.Json.Serialization;

namespace RawgSharp.Models
{
    public class Publisher
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("games_count")]
        public int GamesCount { get; set; }

        [JsonPropertyName("image_background")]
        public string ImageBackground { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
