using System.Net.Http.Headers;
using System.Text.Json;
using Shl.Api.Configuration;
using Shl.Api.Contracts.Games;
using Shl.Api.Contracts.Media;
using Shl.Api.Contracts.Statistics;
using Shl.Api.Contracts.Teams;
using Shl.Api.Models;
using Team = Shl.Api.Contracts.Teams.Team;

namespace Shl.Api;

public class OpenApiClient
{
    private OpenApiConfiguration Configuration { get; set; }
    private readonly HttpClient _httpClient;

    private const string BaseUrl = "https://openapi.shl.se/";
    
    public JsonSerializerOptions? JsonSerializerOptions => new ()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new CustomDateTimeConverter() },
    };

    public OpenApiClient(OpenApiConfiguration configuration)
    {
        Configuration = configuration;
        
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(BaseUrl);
    }

    public async Task<string?> GetToken()
    {
        var encodedContent = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
        {
            new("grant_type", "client_credentials"),
            new("client_id", Configuration.ClientId),
            new("client_secret", Configuration.ClientSecret),
        });
        var response = await _httpClient.PostAsync("/oauth2/token", encodedContent);

        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<BearerTokenProviderResponse>(content);

        return result!.AccessToken;
    }

    private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage httpRequestMessage)
    {
        var token = await GetToken();
        httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _httpClient.SendAsync(httpRequestMessage);
        return response;
    }

    private async Task<T?> InvokeApi<T>(HttpRequestMessage httpRequestMessage)
    {
        var response = await SendRequestAsync(httpRequestMessage);

        response.EnsureSuccessStatusCode();
        
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(responseString, JsonSerializerOptions);
    }

    public async Task<Article[]?> GetArticlesAsync(string[] teamIds)
    {
        var requestUri = $"/articles?teamIds[]={String.Join("&teamIds[]=", teamIds)}";
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<Article[]>(httpRequestMessage);
    }

    public async Task<Game[]?> GetGamesAsync(int season, string[]? teamIds = null)
    {
        var requestUri = teamIds != null 
            ? $"/seasons/{season}/games?teamIds[]={String.Join("&teamIds[]=", teamIds)}"
            : $"/seasons/{season}/games";
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<Game[]>(httpRequestMessage);
    }

    public async Task<GameReport?> GetGameAsync(int season, int gameId)
    {
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"/seasons/{season}/games/{gameId}");
        
        return await InvokeApi<GameReport>(httpRequestMessage);
    }

    public async Task<PlayerStatistics[]?> GetPlayerStatisticsAsync(int season, string? sort = null, string[]? teamIds = null)
    {
        //assists, goals, points, pim, hits or plusminus
        var requestUri = sort != null
            ? $"/seasons/{season}/statistics/players?sort={sort}"
            : $"/seasons/{season}/statistics/players";

        if (teamIds != null)
        {
            var initialCharacter = sort != null ? "&" : "?";
            requestUri = $"{requestUri}{initialCharacter}teamIds[]={String.Join("&teamIds[]=", teamIds)}";
        }
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<PlayerStatistics[]>(httpRequestMessage);
    }

    public async Task<GoalKeeperStatistics[]?> GetGoalKeeperStatisticsAsync(int season, string? sort = null, string[]? teamIds = null)
    {
        //saves, savesPercent, goalsAgainst, goalsAgainstAverage, won, tied, lost, shooutOuts or minutesInPlay
        var requestUri = sort != null
            ? $"/seasons/{season}/statistics/goalkeepers?sort={sort}"
            : $"/seasons/{season}/statistics/goalkeepers";

        if (teamIds != null)
        {
            var initialCharacter = sort != null ? "&" : "?";
            requestUri = $"{requestUri}{initialCharacter}teamIds[]={String.Join("&teamIds[]=", teamIds)}";
        }
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<GoalKeeperStatistics[]>(httpRequestMessage);
    }

    public async Task<TeamStanding[]?> GetStandingsAsync(int season, string[]? teamIds = null)
    {
        var requestUri = $"/seasons/{season}/statistics/teams/standings";

        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        var response = await InvokeApi<TeamStanding[]>(httpRequestMessage);
        
        return teamIds != null
            ? response?.Where(x => teamIds.Contains(x.TeamCode)).ToArray()
            : response;
    }

    public async Task<Team[]?> GetTeams()
    {
        var requestUri = "/teams"; 

        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<Team[]>(httpRequestMessage);
    }

    public async Task<Fact?> GetTeam(string teamCode)
    {
        var requestUri = $"/teams/{teamCode}"; 

        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<Fact>(httpRequestMessage);
    }

    public async Task<Video[]?> GetVideosAsync(string[] teamIds)
    {
        var requestUri = $"/videos?teamIds[]={String.Join("&teamIds[]=", teamIds)}";
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
        
        return await InvokeApi<Video[]>(httpRequestMessage);
    }
}