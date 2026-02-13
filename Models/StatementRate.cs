using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record StatementRate
{
    [JsonPropertyName("Rate")]
    public required string Rate { get; init; }

    [JsonPropertyName("Type")]
    public required Type8 Type { get; init; }
}
