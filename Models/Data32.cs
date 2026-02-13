using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data32
{
    [JsonPropertyName("Account")]
    public IReadOnlyList<AccountModel>? Account { get; init; }
}
