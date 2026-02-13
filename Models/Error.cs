using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Error
{
    [JsonPropertyName("ErrorCode")]
    public required ErrorCode ErrorCode { get; init; }

    [JsonPropertyName("Message")]
    public required string Message { get; init; }

    [JsonPropertyName("Path")]
    public string? Path { get; init; }

    [JsonPropertyName("Url")]
    public string? Url { get; init; }
}
