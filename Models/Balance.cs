using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Balance
{
    [JsonPropertyName("Amount")]
    public required Amount10 Amount { get; init; }

    [JsonPropertyName("CreditDebitIndicator")]
    public required CreditDebitIndicator CreditDebitIndicator { get; init; }

    [JsonPropertyName("Type")]
    public required Type Type { get; init; }
}
