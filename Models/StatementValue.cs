using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record StatementValue
{
    [JsonPropertyName("Value")]
    public required double Value { get; init; }

    [JsonPropertyName("Type")]
    public required Type9 Type { get; init; }
}
