using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Links1
{
    [JsonPropertyName("Self")]
    public required string Self { get; init; }

    [JsonPropertyName("First")]
    public string? First { get; init; }

    [JsonPropertyName("Prev")]
    public string? Prev { get; init; }

    [JsonPropertyName("Next")]
    public string? Next { get; init; }

    [JsonPropertyName("Last")]
    public string? Last { get; init; }
}
