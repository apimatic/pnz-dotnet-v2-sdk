using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Becsremittance
{
    [JsonPropertyName("CreditorName")]
    public required string CreditorName { get; init; }

    [JsonPropertyName("CreditorReference")]
    public CreditorReference? CreditorReference { get; init; }

    [JsonPropertyName("DebtorName")]
    public string? DebtorName { get; init; }

    [JsonPropertyName("DebtorReference")]
    public CreditorReference? DebtorReference { get; init; }
}
