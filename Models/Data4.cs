using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data4
{
    [JsonPropertyName("Balance")]
    public required IReadOnlyList<BalanceModel> Balance { get; init; }
}
