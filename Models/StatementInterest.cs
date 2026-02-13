using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record StatementInterest
{
    [JsonPropertyName("Amount")]
    public required Amount42 Amount { get; init; }

    [JsonPropertyName("CreditDebitIndicator")]
    public required CreditDebitIndicator3 CreditDebitIndicator { get; init; }

    [JsonPropertyName("Type")]
    public required Type6 Type { get; init; }
}
