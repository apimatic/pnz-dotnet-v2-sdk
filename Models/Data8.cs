using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data8
{
    [JsonPropertyName("Party")]
    public PartyModel? Party { get; init; }
}
