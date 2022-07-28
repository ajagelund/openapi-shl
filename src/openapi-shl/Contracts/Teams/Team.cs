using System.Text.Json.Serialization;

namespace Shl.Api.Contracts.Teams;

public class Team
{

    [JsonPropertyName("accreditation")]
    public Accreditation Accreditation { get; set; }

    [JsonPropertyName("contact")]
    public Contact Contact { get; set; }

    [JsonPropertyName("finals")]
    public string Finals { get; set; }

    [JsonPropertyName("founded")]
    public string Founded { get; set; }

    [JsonPropertyName("golds")]
    public string Golds { get; set; }

    [JsonPropertyName("holy")]
    public string Holy { get; set; }

    [JsonPropertyName("team_code")]
    public string TeamCode { get; set; }

    [JsonPropertyName("chairman")]
    public string Chairman { get; set; }

    [JsonPropertyName("president")]
    public string President { get; set; }
}
