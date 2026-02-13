using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record DebtorReference
{
    [JsonPropertyName("Particulars")]
    public string? Particulars { get; init; }

    [JsonPropertyName("Code")]
    public string? Code { get; init; }

    [JsonPropertyName("Reference")]
    public string? Reference { get; init; }
}
