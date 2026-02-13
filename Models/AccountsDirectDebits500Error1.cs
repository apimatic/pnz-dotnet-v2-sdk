using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountsDirectDebits500Error1
{
    [JsonPropertyName("Code")]
    public required string Code { get; init; }

    [JsonPropertyName("Id")]
    public string? Id { get; init; }

    [JsonPropertyName("Message")]
    public required string Message { get; init; }

    [JsonPropertyName("Errors")]
    public required IReadOnlyList<Error> Errors { get; init; }
}
