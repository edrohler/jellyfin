#nullable disable

using System.Text.Json.Serialization;

namespace Emby.Server.Implementations.LiveTv.Listings.SchedulesDirectDtos
{
    /// <summary>
    /// The lineup dto.
    /// </summary>
    public class LineupDto
    {
        /// <summary>
        /// Gets or sets the linup.
        /// </summary>
        [JsonPropertyName("lineup")]
        public string Lineup { get; set; }

        /// <summary>
        /// Gets or sets the lineup name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the transport.
        /// </summary>
        [JsonPropertyName("transport")]
        public string Transport { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
