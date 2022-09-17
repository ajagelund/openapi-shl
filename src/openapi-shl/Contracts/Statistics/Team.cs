using System.Text.Json.Serialization;

namespace HockyGrejer.Api.Contracts.Statistics;

public class Team
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }
}