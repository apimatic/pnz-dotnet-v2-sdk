using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data10
{
    [JsonPropertyName("Statement")]
    public IReadOnlyList<StatementModel>? Statement { get; init; }
}
