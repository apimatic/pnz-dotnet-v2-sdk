using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data6
{
    [JsonPropertyName("StandingOrder")]
    public IReadOnlyList<StandingOrderModel>? StandingOrder { get; init; }
}
