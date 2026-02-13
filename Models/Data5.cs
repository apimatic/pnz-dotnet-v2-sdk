using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data5
{
    [JsonPropertyName("DirectDebit")]
    public IReadOnlyList<DirectDebitModel>? DirectDebit { get; init; }
}
