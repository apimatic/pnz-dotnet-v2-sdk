using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record CardInstrument
{
    [JsonPropertyName("CardSchemeName")]
    public required CardSchemeName CardSchemeName { get; init; }

    [JsonPropertyName("AuthorisationType")]
    public AuthorisationType? AuthorisationType { get; init; }

    [JsonPropertyName("Name")]
    public string? Name { get; init; }

    [JsonPropertyName("Identification")]
    public string? Identification { get; init; }
}
