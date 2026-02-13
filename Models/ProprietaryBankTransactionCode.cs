using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record ProprietaryBankTransactionCode
{
    [JsonPropertyName("Code")]
    public required string Code { get; init; }

    [JsonPropertyName("Issuer")]
    public string? Issuer { get; init; }
}
