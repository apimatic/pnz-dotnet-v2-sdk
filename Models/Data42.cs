using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data42
{
    [JsonPropertyName("Account")]
    public AccountModel? Account { get; init; }
}
