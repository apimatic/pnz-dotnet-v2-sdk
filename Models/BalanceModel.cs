using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record BalanceModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("Amount")]
    public required Amount10 Amount { get; init; }

    [JsonPropertyName("CreditDebitIndicator")]
    public required CreditDebitIndicator CreditDebitIndicator { get; init; }

    [JsonPropertyName("Type")]
    public required Type Type { get; init; }

    [JsonPropertyName("DateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset DateTime { get; init; }

    [JsonPropertyName("CreditLine")]
    public IReadOnlyList<CreditLine>? CreditLine { get; init; }
}
