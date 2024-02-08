using System.Text.Json.Serialization;

namespace RawgSharp.Models
{
    public class Game
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_original")]
        public string NameOriginal { get; set; }

        [JsonPropertyName("alternative_names")]
        public string[] AlternativeNames { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("metacritic")]
        public double? Metacritic { get; set; }

        [JsonPropertyName("metacritic_url")]
        public string MetacriticUrl { get; set; }

        [JsonPropertyName("metacritic_platforms")]
        public IEnumerable<GamePlatformMetacritic> MetacriticPlatforms { get; set; }

        [JsonPropertyName("released")]
        public DateTime? Released { get; set; }

        [JsonPropertyName("tba")]
        public bool TBA { get; set; }

        [JsonPropertyName("updated")]
        public DateTime? Updated { get; set; }

        [JsonPropertyName("background_image")]
        public string BackgroundImage { get; set; }

        [JsonPropertyName("background_image_additional")]
        public string BackgroundImageAdditional { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

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

        [JsonPropertyName("playtime")]
        public int Playtime { get; set; }

        [JsonPropertyName("suggestions_count")]
        public int SuggestionsCount { get; set; }

        [JsonPropertyName("esrb_rating")]
        public EsrbRating EsrbRating { get; set; }

        [JsonPropertyName("platforms")]
        public IEnumerable<GamePlatform> Platforms { get; set; }

        [JsonPropertyName("genres")]
        public IEnumerable<Genre> Genres { get; set; }

        [JsonPropertyName("developers")]
        public IEnumerable<Developer> Developers { get; set; }

        [JsonPropertyName("publishers")]
        public IEnumerable<Publisher> Publishers { get; set; }
    }
}