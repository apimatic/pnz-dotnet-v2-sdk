using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record Data62
{
    [JsonPropertyName("Beneficiary")]
    public IReadOnlyList<BeneficiaryModel>? Beneficiary { get; init; }
}
