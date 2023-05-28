using System.Text.Json.Serialization;

namespace RawgSharp.Models
{
    public class GameItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("released")]
        public DateTime Released { get; set; }

        [JsonPropertyName("tba")]
        public bool TBA { get; set; }

        [JsonPropertyName("background_image")]
        public string BackgroundImage { get; set; }

        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        [JsonPropertyName("rating_top")]
        public int RatingTop { get; set; }

        [JsonPropertyName("ratings")]
        public object Ratings { get; set; }

        [JsonPropertyName("ratings_count")]
        public int RatingsCount { get; set; }

        [JsonPropertyName("reviews_text_count")]
        public int ReviewsTextCount { get; set; }

        [JsonPropertyName("added")]
        public int Added { get; set; }

        [JsonPropertyName("added_by_status")]
        public object AddedByStatus { get; set; }

        [JsonPropertyName("metacritic")]
        public double? Metacritic { get; set; }

        [JsonPropertyName("playtime")]
        public int Playtime { get; set; }

        [JsonPropertyName("suggestions_count")]
        public int SuggestionsCount { get; set; }

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("esrb_rating")]
        public EsrbRating EsrbRating { get; set; }

        [JsonPropertyName("platforms")]
        public object[] Platforms { get; set; }
    }
}