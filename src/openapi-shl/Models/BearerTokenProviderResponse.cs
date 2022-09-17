using System.Text.Json.Serialization;

namespace HockyGrejer.Api.Models;

internal class BearerTokenProviderResponse
{
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }
    [JsonPropertyName("expires_in")]
    public int ExpiresInSeconds { get; set; }
}