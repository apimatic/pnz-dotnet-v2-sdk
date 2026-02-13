using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record GeoLocation
{
    [JsonPropertyName("Latitude")]
    public string? Latitude { get; init; }

    [JsonPropertyName("Longitude")]
    public string? Longitude { get; init; }
}
