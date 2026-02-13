using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record BankTransactionCode2
{
    [JsonPropertyName("Code")]
    public required string Code { get; init; }

    [JsonPropertyName("SubCode")]
    public required string SubCode { get; init; }
}
