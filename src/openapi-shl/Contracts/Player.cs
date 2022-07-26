using System.Text.Json.Serialization;

namespace Shl.Api.Contracts;

public class Player
{

    [JsonPropertyName("assistant")]
    public bool Assistant { get; set; }

    [JsonPropertyName("captain")]
    public bool Captain { get; set; }

    [JsonPropertyName("date_of_birth")]
    public string DateOfBirth { get; set; }

    [JsonPropertyName("default_jersey")]
    public int DefaultJersey { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; }

    [JsonPropertyName("player_id")]
    public string PlayerId { get; set; }

    [JsonPropertyName("player_url_desktop")]
    public string PlayerUrlDesktop { get; set; }

    [JsonPropertyName("player_url_mobile")]
    public string PlayerUrlMobile { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("shoots")]
    public string Shoots { get; set; }

    [JsonPropertyName("shoots_right")]
    public bool ShootsRight { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }
}