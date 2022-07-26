using System.Text.Json.Serialization;

namespace Shl.Api.Contracts;

public class Contact
{

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }
}