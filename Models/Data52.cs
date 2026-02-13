using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data52
{
    [JsonPropertyName("Balance")]
    public required IReadOnlyList<BalanceModel> Balance { get; init; }
}
