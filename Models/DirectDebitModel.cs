using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record DirectDebitModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("DirectDebitId")]
    public string? DirectDebitId { get; init; }

    [JsonPropertyName("MandateIdentification")]
    public required string MandateIdentification { get; init; }

    [JsonPropertyName("DirectDebitStatusCode")]
    public DirectDebitStatusCode? DirectDebitStatusCode { get; init; }

    [JsonPropertyName("Name")]
    public required string Name { get; init; }

    [JsonPropertyName("PreviousPaymentDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? PreviousPaymentDateTime { get; init; }

    [JsonPropertyName("PreviousPaymentAmount")]
    public PreviousPaymentAmount2? PreviousPaymentAmount { get; init; }
}
