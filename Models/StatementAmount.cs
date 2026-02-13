using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record StatementAmount
{
    [JsonPropertyName("Amount")]
    public required Amount42 Amount { get; init; }

    [JsonPropertyName("CreditDebitIndicator")]
    public required CreditDebitIndicator3 CreditDebitIndicator { get; init; }

    [JsonPropertyName("Type")]
    public required Type10 Type { get; init; }
}
