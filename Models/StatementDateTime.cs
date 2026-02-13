using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record StatementDateTime
{
    [JsonPropertyName("DateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset DateTime { get; init; }

    [JsonPropertyName("Type")]
    public required Type7 Type { get; init; }
}
