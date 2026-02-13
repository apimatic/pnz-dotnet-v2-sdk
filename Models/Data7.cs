using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data7
{
    [JsonPropertyName("Offer")]
    public IReadOnlyList<OfferModel>? Offer { get; init; }
}
