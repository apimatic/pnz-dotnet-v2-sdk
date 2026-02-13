using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Amount
{
    [JsonPropertyName("Amount")]
    public required string AmountAmount { get; init; }

    [JsonPropertyName("Currency")]
    public required string Currency { get; init; }
}
