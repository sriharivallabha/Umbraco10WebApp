using Newtonsoft.Json;

namespace Umbraco10WebApp.API
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class SpaceNews
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "newsSite")]
        public string NewsSite { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        [JsonProperty(PropertyName = "publishedAt")]
        public DateTime PublishedAt { get; set; }

        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "featured")]
        public bool Featured { get; set; }

        [JsonProperty(PropertyName = "launches")]
        public List<object>? Launches { get; set; }

        [JsonProperty(PropertyName = "events")]
        public List<object>? Events { get; set; }
        
    }
}
