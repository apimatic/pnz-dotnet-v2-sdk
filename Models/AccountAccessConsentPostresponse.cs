using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountAccessConsentPostresponse
{
    [JsonPropertyName("Data")]
    public required AccountAccessConsentResponseModel Data { get; init; }

    [JsonPropertyName("Risk")]
    public required Risk1 Risk { get; init; }

    [JsonPropertyName("Links")]
    public required Links1 Links { get; init; }

    [JsonPropertyName("Meta")]
    public required Meta Meta { get; init; }
}
