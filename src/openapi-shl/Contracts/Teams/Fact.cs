using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HockyGrejer.Api.Contracts.Teams;

public class Fact
{

    [JsonPropertyName("facts")]
    public Facts Facts { get; set; }

    [JsonPropertyName("players")]
    public IList<Player> Players { get; set; }

    [JsonPropertyName("staff")]
    public IList<Staff> Staff { get; set; }
}