using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LiveTVAdmin.Shared
{
    public class Episode
    {
        public Episode()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        [JsonProperty("id")]
        public string Id { get; set; }

        [Required]
        [JsonProperty("showId")]
        public string ShowId { get; set; }

        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        [Required]
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("communityLinksUrl")]
        public string CommunityLinksUrl { get; set; }

        [JsonProperty("showNotesUrl")]
        public string ShowNotesUrl { get; set; }

        [Required]
        [JsonProperty("description")]
        public string Description { get; set; }

        [Required]
        [JsonProperty("scheduledStartTime")]
        public DateTime ScheduledStartTime { get; set; }

        [Required]
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonIgnore]
        public bool IsEditing { get; set; }

    }
}
