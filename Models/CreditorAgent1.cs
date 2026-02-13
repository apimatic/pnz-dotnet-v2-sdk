using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record CreditorAgent1
{
    [JsonPropertyName("SchemeName")]
    public SchemeName? SchemeName { get; init; }

    [JsonPropertyName("Identification")]
    public string? Identification { get; init; }

    [JsonPropertyName("Name")]
    public string? Name { get; init; }

    [JsonPropertyName("PostalAddress")]
    public PostalAddress2? PostalAddress { get; init; }
}
