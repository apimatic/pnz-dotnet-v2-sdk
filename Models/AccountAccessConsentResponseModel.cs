using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record AccountAccessConsentResponseModel
{
    [JsonPropertyName("ConsentId")]
    public required string ConsentId { get; init; }

    [JsonPropertyName("Status")]
    public required Status Status { get; init; }

    [JsonPropertyName("CreationDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset CreationDateTime { get; init; }

    [JsonPropertyName("StatusUpdateDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset StatusUpdateDateTime { get; init; }

    [JsonPropertyName("Consent")]
    public required Consent1 Consent { get; init; }
}
