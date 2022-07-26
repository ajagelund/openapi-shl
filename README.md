# Shl.OpenApi

This is an implementation of the Open API for the Swedish Hockey League (SHL) written in C#.

## SHL Open API
Swagger and Documentation: http://doc.openapi.shl.se


## Install
```bash
Install-Package Shl.OpenApi
```

## Usage
```csharp

using Shl.Api;
using Shl.Api.Configuration;

...

var client = new OpenApiClient(new OpenApiConfiguration("client_id","client_secret"));

var teams = await client.GetTeams();

foreach (var team in teams)
{
    Console.WriteLine($"{team.President} of {team.TeamCode}");
}

...

var games = await client.GetGamesAsync(2021);
foreach (var game in games)
{
    Console.WriteLine($"{game.HomeTeamCode}-{game.AwayTeamCode} {game.HomeTeamResult}-{game.AwayTeamResult}");
}

```
