using System.Text.Json.Serialization;

namespace SwedishHockeyLeague.Api.Contracts.Games;

public class Live
{

    [JsonPropertyName("gametime")]
    public string Gametime { get; set; }

    [JsonPropertyName("time_period")]
    public int TimePeriod { get; set; }

    [JsonPropertyName("game_id")]
    public int GameId { get; set; }

    [JsonPropertyName("period")]
    public int Period { get; set; }

    [JsonPropertyName("round")]
    public int Round { get; set; }

    [JsonPropertyName("home_team_code")]
    public string HomeTeamCode { get; set; }

    [JsonPropertyName("home_score")]
    public int HomeScore { get; set; }

    [JsonPropertyName("away_team_code")]
    public string AwayTeamCode { get; set; }

    [JsonPropertyName("away_score")]
    public int AwayScore { get; set; }

    [JsonPropertyName("venue")]
    public string Venue { get; set; }

    [JsonPropertyName("attendance")]
    public int Attendance { get; set; }

    [JsonPropertyName("status_string")]
    public string StatusString { get; set; }
}