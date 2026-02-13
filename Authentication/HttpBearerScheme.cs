using PnzApi.Core.Authentication;
using PnzApi.Core.Authentication.Models;
using System.Net.Http.Headers;

namespace PnzApi.Authentication;

public class HttpBearerScheme : IAuthScheme
{
    private readonly Func<string> _factory;

    public HttpBearerScheme(string token)
    {
        _factory = () => token;
    }

    public HttpBearerScheme(Func<string> factory)
    {
        _factory = factory;
    }

    public ValueTask Apply(HttpRequestMessage request, CancellationToken ct)
    {
        var token = _factory();
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        return default;
    }
}
