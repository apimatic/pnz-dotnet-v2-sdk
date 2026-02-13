using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data21
{
    [JsonPropertyName("Statement")]
    public IReadOnlyList<StatementModel>? Statement { get; init; }
}
