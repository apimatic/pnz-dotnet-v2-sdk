using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record BeneficiaryModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("BeneficiaryId")]
    public string? BeneficiaryId { get; init; }

    [JsonPropertyName("Reference")]
    public Reference? Reference { get; init; }

    [JsonPropertyName("CreditorAgent")]
    public CreditorAgent12? CreditorAgent { get; init; }

    [JsonPropertyName("CreditorAccount")]
    public CreditorAccount2? CreditorAccount { get; init; }
}
