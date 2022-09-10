using System.Text.Json.Serialization;

namespace SwedishHockeyLeague.Api.Contracts.Teams;

public class Fact
{

    [JsonPropertyName("facts")]
    public Facts Facts { get; set; }

    [JsonPropertyName("players")]
    public IList<Player> Players { get; set; }

    [JsonPropertyName("staff")]
    public IList<Staff> Staff { get; set; }
}