using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record MetaData
{
    [JsonPropertyName("TotalPages")]
    public double? TotalPages { get; init; }

    [JsonPropertyName("FirstAvailableDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? FirstAvailableDateTime { get; init; }

    [JsonPropertyName("LastAvailableDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? LastAvailableDateTime { get; init; }
}
