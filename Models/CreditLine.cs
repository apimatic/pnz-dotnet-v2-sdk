using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record CreditLine
{
    [JsonPropertyName("Included")]
    public required bool Included { get; init; }

    [JsonPropertyName("Amount")]
    public Amount10? Amount { get; init; }

    [JsonPropertyName("Type")]
    public Type1? Type { get; init; }
}
