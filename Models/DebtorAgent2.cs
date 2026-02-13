using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record DebtorAgent2
{
    [JsonPropertyName("SchemeName")]
    public required string SchemeName { get; init; }

    [JsonPropertyName("Identification")]
    public required string Identification { get; init; }
}
