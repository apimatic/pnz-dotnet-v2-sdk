using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record CreditorAccount
{
    [JsonPropertyName("SchemeName")]
    public required AccountSchemeModel SchemeName { get; init; }

    [JsonPropertyName("Identification")]
    public required string Identification { get; init; }

    [JsonPropertyName("Name")]
    public string? Name { get; init; }

    [JsonPropertyName("SecondaryIdentification")]
    public string? SecondaryIdentification { get; init; }
}
