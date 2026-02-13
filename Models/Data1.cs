using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data1
{
    [JsonPropertyName("Account")]
    public AccountModel? Account { get; init; }
}
