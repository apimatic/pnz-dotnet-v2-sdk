using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record AccountModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("Currency")]
    public required string Currency { get; init; }

    [JsonPropertyName("AccountType")]
    public AccountType? AccountType { get; init; }

    [JsonPropertyName("AccountSubType")]
    public AccountSubType? AccountSubType { get; init; }

    [JsonPropertyName("Description")]
    public string? Description { get; init; }

    [JsonPropertyName("Nickname")]
    public required string Nickname { get; init; }

    [JsonPropertyName("Account")]
    public Account3? Account { get; init; }

    [JsonPropertyName("Servicer")]
    public Servicer2? Servicer { get; init; }
}
