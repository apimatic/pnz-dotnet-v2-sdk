using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountGetresponse
{
    [JsonPropertyName("Data")]
    public required Data32 Data { get; init; }

    [JsonPropertyName("Links")]
    public required Links1 Links { get; init; }

    [JsonPropertyName("Meta")]
    public required Meta Meta { get; init; }
}
