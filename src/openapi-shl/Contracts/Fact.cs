using System.Text.Json.Serialization;

namespace Shl.Api.Contracts;

public class Fact
{

    [JsonPropertyName("facts")]
    public Facts Facts { get; set; }

    [JsonPropertyName("players")]
    public IList<Player> Players { get; set; }

    [JsonPropertyName("staff")]
    public IList<Staff> Staff { get; set; }
}