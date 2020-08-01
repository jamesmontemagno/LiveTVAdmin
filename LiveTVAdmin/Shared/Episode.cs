using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveTVAdmin.Shared
{
    public class Episode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("showId")]
        public string ShowId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("communityLinksUrl")]
        public string CommunityLinksUrl { get; set; }

        [JsonProperty("showNotesUrl")]
        public string ShowNotesUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduledStartTime")]
        public DateTime ScheduledStartTime { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }
}
