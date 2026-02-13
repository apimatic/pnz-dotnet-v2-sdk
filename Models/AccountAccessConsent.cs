using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountAccessConsent
{
    [JsonPropertyName("Data")]
    public required AccountAccessConsentModel Data { get; init; }

    [JsonPropertyName("Risk")]
    public required Risk1 Risk { get; init; }
}
