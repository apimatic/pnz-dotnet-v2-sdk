using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record StatementBenefit
{
    [JsonPropertyName("Amount")]
    public required Amount42 Amount { get; init; }

    [JsonPropertyName("Type")]
    public required Type4 Type { get; init; }
}
