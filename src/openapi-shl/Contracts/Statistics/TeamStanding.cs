using System.Text.Json.Serialization;

namespace Shl.Api.Contracts.Statistics;

public class TeamStanding
{

    [JsonPropertyName("gp")]
    public int Gp { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("team")]
    public Team Team { get; set; }

    [JsonPropertyName("team_code")]
    public string TeamCode { get; set; }

    [JsonPropertyName("diff")]
    public int Diff { get; set; }

    [JsonPropertyName("g")]
    public int G { get; set; }

    [JsonPropertyName("ga")]
    public int Ga { get; set; }

    [JsonPropertyName("non_reg_l")]
    public int NonRegL { get; set; }

    [JsonPropertyName("non_reg_non_w")]
    public int NonRegNonW { get; set; }

    [JsonPropertyName("non_reg_t")]
    public int NonRegT { get; set; }

    [JsonPropertyName("non_reg_w")]
    public int NonRegW { get; set; }

    [JsonPropertyName("otl")]
    public int Otl { get; set; }

    [JsonPropertyName("ott")]
    public int Ott { get; set; }

    [JsonPropertyName("otw")]
    public int Otw { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }

    [JsonPropertyName("reg_l")]
    public int RegL { get; set; }

    [JsonPropertyName("reg_t")]
    public int RegT { get; set; }

    [JsonPropertyName("reg_w")]
    public int RegW { get; set; }

    [JsonPropertyName("sol")]
    public int Sol { get; set; }

    [JsonPropertyName("sow")]
    public int Sow { get; set; }
}