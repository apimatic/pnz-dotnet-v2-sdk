using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record Statement
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("StatementId")]
    public string? StatementId { get; init; }

    [JsonPropertyName("StatementReference")]
    public string? StatementReference { get; init; }

    [JsonPropertyName("Type")]
    public required Type3 Type { get; init; }

    [JsonPropertyName("StartDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset StartDateTime { get; init; }

    [JsonPropertyName("EndDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset EndDateTime { get; init; }

    [JsonPropertyName("CreationDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset CreationDateTime { get; init; }

    [JsonPropertyName("StatementDescription")]
    public IReadOnlyList<string>? StatementDescription { get; init; }

    [JsonPropertyName("StatementBenefit")]
    public IReadOnlyList<StatementBenefit>? StatementBenefit { get; init; }

    [JsonPropertyName("StatementFee")]
    public IReadOnlyList<StatementFee>? StatementFee { get; init; }

    [JsonPropertyName("StatementInterest")]
    public IReadOnlyList<StatementInterest>? StatementInterest { get; init; }

    [JsonPropertyName("StatementDateTime")]
    public IReadOnlyList<StatementDateTime>? StatementDateTime { get; init; }

    [JsonPropertyName("StatementRate")]
    public IReadOnlyList<StatementRate>? StatementRate { get; init; }

    [JsonPropertyName("StatementValue")]
    public IReadOnlyList<StatementValue>? StatementValue { get; init; }

    [JsonPropertyName("StatementAmount")]
    public IReadOnlyList<StatementAmount>? StatementAmount { get; init; }
}
