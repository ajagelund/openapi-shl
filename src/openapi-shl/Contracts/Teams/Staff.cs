using System.Text.Json.Serialization;

namespace Shl.Api.Contracts.Teams;

public class Staff
{

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }

    [JsonPropertyName("staff_id")]
    public string StaffId { get; set; }

    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }
}