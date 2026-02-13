using System.Text;

namespace PnzApi.Core.Authentication.Models;

public sealed class BasicAuthCredentials
{
    private readonly string _username;
    private readonly string _password;

    public BasicAuthCredentials(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public string Encode()
    {
        var raw = $"{_username}:{_password}";
        var bytes = Encoding.UTF8.GetBytes(raw);
        return Convert.ToBase64String(bytes);
    }
}