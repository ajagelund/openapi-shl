namespace HockyGrejer.Api.Configuration;

public class OpenApiConfiguration
{
    public OpenApiConfiguration(string ClientId, string ClientSecret)
    {
        this.ClientId = ClientId;
        this.ClientSecret = ClientSecret;
    }

    public string ClientId { get; }
    public string ClientSecret { get; }
}