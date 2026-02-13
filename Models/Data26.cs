using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data26
{
    [JsonPropertyName("Transaction")]
    public IReadOnlyList<TransactionModel>? Transaction { get; init; }
}
