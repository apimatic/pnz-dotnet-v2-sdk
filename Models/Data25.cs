using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data25
{
    [JsonPropertyName("StandingOrder")]
    public IReadOnlyList<StandingOrderModel>? StandingOrder { get; init; }
}
