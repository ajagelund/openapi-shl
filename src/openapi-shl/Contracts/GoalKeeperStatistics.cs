using System.Text.Json.Serialization;

namespace Shl.Api.Contracts;

public class GoalKeeperStatistics
{

    [JsonPropertyName("gp")]
    public int Gp { get; set; }

    [JsonPropertyName("gpi")]
    public int Gpi { get; set; }

    [JsonPropertyName("info")]
    public Info Info { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("ga")]
    public int Ga { get; set; }

    [JsonPropertyName("gaa")]
    public double? Gaa { get; set; }

    [JsonPropertyName("gs")]
    public int Gs { get; set; }

    [JsonPropertyName("l")]
    public int L { get; set; }

    [JsonPropertyName("mip")]
    public string Mip { get; set; }

    [JsonPropertyName("so")]
    public int So { get; set; }

    [JsonPropertyName("soga")]
    public int Soga { get; set; }

    [JsonPropertyName("svs")]
    public int Svs { get; set; }

    [JsonPropertyName("svsperc")]
    public double? Svsperc { get; set; }

    [JsonPropertyName("t")]
    public int T { get; set; }

    [JsonPropertyName("valid_ranking")]
    public bool ValidRanking { get; set; }

    [JsonPropertyName("w")]
    public int W { get; set; }
}