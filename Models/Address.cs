using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Address
{
    [JsonPropertyName("AddressType")]
    public AddressType1? AddressType { get; init; }

    [JsonPropertyName("AddressLine")]
    public IReadOnlyList<string>? AddressLine { get; init; }

    [JsonPropertyName("StreetName")]
    public string? StreetName { get; init; }

    [JsonPropertyName("BuildingNumber")]
    public string? BuildingNumber { get; init; }

    [JsonPropertyName("PostCode")]
    public string? PostCode { get; init; }

    [JsonPropertyName("TownName")]
    public string? TownName { get; init; }

    [JsonPropertyName("CountrySubDivision")]
    public string? CountrySubDivision { get; init; }

    [JsonPropertyName("Country")]
    public required string Country { get; init; }
}
