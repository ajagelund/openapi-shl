using System.Text.Json.Serialization;

namespace Shl.Api.Contracts.Teams;

public class Accreditation
{

    [JsonPropertyName("contact_information")]
    public string ContactInformation { get; set; }
}