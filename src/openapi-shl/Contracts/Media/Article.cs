using System.Text.Json.Serialization;

namespace HockyGrejer.Api.Contracts.Media;

public class Article
{

    [JsonPropertyName("article_id")]
    public string ArticleId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("intro")]
    public string Intro { get; set; }

    [JsonPropertyName("author")]
    public Author Author { get; set; }

    [JsonPropertyName("publish_date")]
    public DateTime PublishDate { get; set; }

    [JsonPropertyName("article_url")]
    public string ArticleUrl { get; set; }

    [JsonPropertyName("team_code")]
    public string TeamCode { get; set; }
}