using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record Consent
{
    [JsonPropertyName("Permissions")]
    public required IReadOnlyList<Permission> Permissions { get; init; }

    [JsonPropertyName("ExpirationDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? ExpirationDateTime { get; init; }

    [JsonPropertyName("TransactionFromDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? TransactionFromDateTime { get; init; }

    [JsonPropertyName("TransactionToDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? TransactionToDateTime { get; init; }
}
