using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data12
{
    [JsonPropertyName("Transaction")]
    public IReadOnlyList<TransactionModel>? Transaction { get; init; }
}
