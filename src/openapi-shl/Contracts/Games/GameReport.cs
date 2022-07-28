using System.Text.Json.Serialization;

namespace Shl.Api.Contracts.Games;

public class GameReport
        {

            [JsonPropertyName("live")]
            public Live Live { get; set; }

            [JsonPropertyName("game_id")]
            public int GameId { get; set; }

            [JsonPropertyName("game_uuid")]
            public string GameUuid { get; set; }

            [JsonPropertyName("season")]
            public string Season { get; set; }

            [JsonPropertyName("series")]
            public string Series { get; set; }

            [JsonPropertyName("game_type")]
            public string GameType { get; set; }

            [JsonPropertyName("round_number")]
            public int RoundNumber { get; set; }

            [JsonPropertyName("start_date_time")]
            public DateTime StartDateTime { get; set; }

            [JsonPropertyName("home_team_code")]
            public string HomeTeamCode { get; set; }

            [JsonPropertyName("home_team_result")]
            public int HomeTeamResult { get; set; }

            [JsonPropertyName("away_team_code")]
            public string AwayTeamCode { get; set; }

            [JsonPropertyName("away_team_result")]
            public int AwayTeamResult { get; set; }

            [JsonPropertyName("period_results")]
            public string PeriodResults { get; set; }

            [JsonPropertyName("game_center_active")]
            public bool GameCenterActive { get; set; }

            [JsonPropertyName("played")]
            public bool Played { get; set; }

            [JsonPropertyName("overtime")]
            public bool Overtime { get; set; }

            [JsonPropertyName("penalty_shots")]
            public bool PenaltyShots { get; set; }

            [JsonPropertyName("ticket_url")]
            public string TicketUrl { get; set; }

            [JsonPropertyName("game_center_url_desktop")]
            public string GameCenterUrlDesktop { get; set; }

            [JsonPropertyName("game_center_url_mobile")]
            public string GameCenterUrlMobile { get; set; }

            [JsonPropertyName("tv_channels")]
            public IList<string> TvChannels { get; set; }

            [JsonPropertyName("venue")]
            public string Venue { get; set; }
        }