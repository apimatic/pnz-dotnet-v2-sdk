using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record StandingOrderModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("StandingOrderId")]
    public string? StandingOrderId { get; init; }

    [JsonPropertyName("Frequency")]
    public required string Frequency { get; init; }

    [JsonPropertyName("Reference")]
    public Reference? Reference { get; init; }

    [JsonPropertyName("FirstPaymentDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? FirstPaymentDateTime { get; init; }

    [JsonPropertyName("FirstPaymentAmount")]
    public FirstPaymentAmount2? FirstPaymentAmount { get; init; }

    [JsonPropertyName("NextPaymentDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset NextPaymentDateTime { get; init; }

    [JsonPropertyName("NextPaymentAmount")]
    public required NextPaymentAmount2 NextPaymentAmount { get; init; }

    [JsonPropertyName("FinalPaymentDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? FinalPaymentDateTime { get; init; }

    [JsonPropertyName("FinalPaymentAmount")]
    public FinalPaymentAmount2? FinalPaymentAmount { get; init; }

    [JsonPropertyName("StandingOrderStatusCode")]
    public StandingOrderStatusCode? StandingOrderStatusCode { get; init; }

    [JsonPropertyName("CreditorAgent")]
    public CreditorAgent22? CreditorAgent { get; init; }

    [JsonPropertyName("CreditorAccount")]
    public CreditorAccount2? CreditorAccount { get; init; }
}
