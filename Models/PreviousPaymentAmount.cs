using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record PreviousPaymentAmount
{
    [JsonPropertyName("Amount")]
    public required string Amount { get; init; }

    [JsonPropertyName("Currency")]
    public required string Currency { get; init; }
}
