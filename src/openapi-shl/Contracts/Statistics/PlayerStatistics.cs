using System.Text.Json.Serialization;

namespace HockyGrejer.Api.Contracts.Statistics;

public class PlayerStatistics
{

    [JsonPropertyName("gp")]
    public int Gp { get; set; }

    [JsonPropertyName("info")]
    public Info Info { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("toi")]
    public int Toi { get; set; }

    [JsonPropertyName("toi_gp")]
    public string ToiGp { get; set; }

    [JsonPropertyName("a")]
    public int A { get; set; }

    [JsonPropertyName("bk_s")]
    public int BkS { get; set; }

    [JsonPropertyName("g")]
    public int G { get; set; }

    [JsonPropertyName("gwg")]
    public int Gwg { get; set; }

    [JsonPropertyName("hits")]
    public int Hits { get; set; }

    [JsonPropertyName("minus")]
    public int Minus { get; set; }

    [JsonPropertyName("pim")]
    public int Pim { get; set; }

    [JsonPropertyName("ppg")]
    public int Ppg { get; set; }

    [JsonPropertyName("plus")]
    public int Plus { get; set; }

    [JsonPropertyName("plus_minus")]
    public int PlusMinus { get; set; }

    [JsonPropertyName("sog")]
    public int Sog { get; set; }

    [JsonPropertyName("tp")]
    public int Tp { get; set; }
}