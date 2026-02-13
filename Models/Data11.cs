using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data11
{
    [JsonPropertyName("Statement")]
    public Statement? Statement { get; init; }
}
