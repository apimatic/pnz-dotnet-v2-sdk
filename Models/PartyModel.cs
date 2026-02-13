using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record PartyModel
{
    [JsonPropertyName("PartyId")]
    public required string PartyId { get; init; }

    [JsonPropertyName("PartyNumber")]
    public string? PartyNumber { get; init; }

    [JsonPropertyName("PartyType")]
    public PartyType? PartyType { get; init; }

    [JsonPropertyName("Name")]
    public string? Name { get; init; }

    [JsonPropertyName("EmailAddress")]
    public string? EmailAddress { get; init; }

    [JsonPropertyName("Phone")]
    public string? Phone { get; init; }

    [JsonPropertyName("Mobile")]
    public string? Mobile { get; init; }

    [JsonPropertyName("Address")]
    public IReadOnlyList<Address>? Address { get; init; }
}
