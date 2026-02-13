using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record OfferModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("OfferId")]
    public string? OfferId { get; init; }

    [JsonPropertyName("OfferType")]
    public OfferType? OfferType { get; init; }

    [JsonPropertyName("Description")]
    public string? Description { get; init; }

    [JsonPropertyName("StartDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? StartDateTime { get; init; }

    [JsonPropertyName("EndDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? EndDateTime { get; init; }

    [JsonPropertyName("Amount")]
    public Amount42? Amount { get; init; }

    [JsonPropertyName("Fee")]
    public Fee2? Fee { get; init; }

    [JsonPropertyName("Rate")]
    public string? Rate { get; init; }

    [JsonPropertyName("Value")]
    public double? Value { get; init; }

    [JsonPropertyName("Term")]
    public string? Term { get; init; }

    [JsonPropertyName("URL")]
    public string? Url { get; init; }
}
