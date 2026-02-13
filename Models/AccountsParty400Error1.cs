using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountsParty400Error1
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
