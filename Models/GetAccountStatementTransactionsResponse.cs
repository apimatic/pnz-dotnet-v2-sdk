using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record GetAccountStatementTransactionsResponse
{
    [JsonPropertyName("Data")]
    public required Data12 Data { get; init; }

    [JsonPropertyName("Links")]
    public required Links1 Links { get; init; }

    [JsonPropertyName("Meta")]
    public required Meta Meta { get; init; }
}
