using Newtonsoft.Json;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco10WebApp.Data.Models;

namespace Umbraco10WebApp.Site.Models
{

    public class SpaceNewsItem
    {
        public int Id { get; set; }


        public string Title { get; set; }


        public string Url { get; set; }


        public string ImageUrl { get; set; }


        public string NewsSite { get; set; }


        public string Summary { get; set; }


        public DateTime PublishedAt { get; set; }


        public DateTime UpdatedAt { get; set; }


        public bool Featured { get; set; }


        public List<object>? Launches { get; set; }


        public List<object>? Events { get; set; }

    }
}
