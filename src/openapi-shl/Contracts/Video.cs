using System.Text.Json.Serialization;

namespace Shl.Api.Contracts;

public class Video
{

    [JsonPropertyName("video_id")]
    public int VideoId { get; set; }

    [JsonPropertyName("length")]
    public int Length { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("team_code")]
    public string TeamCode { get; set; }

    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }

    [JsonPropertyName("publish_date")]
    public DateTime PublishDate { get; set; }

    [JsonPropertyName("video_playback_url")]
    public string VideoPlaybackUrl { get; set; }
}