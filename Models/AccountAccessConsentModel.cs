using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountAccessConsentModel
{
    [JsonPropertyName("Consent")]
    public required Consent1 Consent { get; init; }
}
