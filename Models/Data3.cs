using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data3
{
    [JsonPropertyName("Beneficiary")]
    public IReadOnlyList<BeneficiaryModel>? Beneficiary { get; init; }
}
