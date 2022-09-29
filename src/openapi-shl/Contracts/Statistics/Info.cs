using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Shl.Api.Contracts.Statistics;

public class Info
{

    [JsonPropertyName("birthdate")]
    public string Birthdate { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("team")]
    public Team Team { get; set; }

    [JsonPropertyName("team_code")]
    public string TeamCode { get; set; }

    [JsonPropertyName("teams")]
    public IList<string> Teams { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
