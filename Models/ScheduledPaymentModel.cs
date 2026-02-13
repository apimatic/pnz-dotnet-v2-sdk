using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record ScheduledPaymentModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("ScheduledPaymentId")]
    public string? ScheduledPaymentId { get; init; }

    [JsonPropertyName("ScheduledPaymentDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset ScheduledPaymentDateTime { get; init; }

    [JsonPropertyName("ScheduledType")]
    public required ScheduledType ScheduledType { get; init; }

    [JsonPropertyName("InstructedAmount")]
    public required InstructedAmount12 InstructedAmount { get; init; }

    [JsonPropertyName("Reference")]
    public Reference? Reference { get; init; }

    [JsonPropertyName("CreditorAgent")]
    public CreditorAgent3? CreditorAgent { get; init; }

    [JsonPropertyName("CreditorAccount")]
    public CreditorAccount5? CreditorAccount { get; init; }
}
