using System.Text.Json.Serialization;

namespace SwedishHockeyLeague.Api.Contracts.Media;

public class Author
{

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }
}