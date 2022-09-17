using System.Text.Json.Serialization;

namespace HockyGrejer.Api.Contracts.Teams;

public class Accreditation
{

    [JsonPropertyName("contact_information")]
    public string ContactInformation { get; set; }
}