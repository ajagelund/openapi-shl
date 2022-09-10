using System.Text.Json.Serialization;

namespace SwedishHockeyLeague.Api.Contracts.Teams;

public class Accreditation
{

    [JsonPropertyName("contact_information")]
    public string ContactInformation { get; set; }
}