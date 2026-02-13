namespace PnzApi.Core.Authentication.Models;

public sealed class OAuth2ClientCredentials
{
    public string? Scope { get; }
    public string ClientId { get; }
    public string ClientSecret { get; }
    public string GrantType => "client_credentials";

    public OAuth2ClientCredentials(string clientId, string clientSecret, string? scope)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
        Scope = scope;
    }
}