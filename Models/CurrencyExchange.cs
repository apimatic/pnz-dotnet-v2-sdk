using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record CurrencyExchange
{
    [JsonPropertyName("SourceCurrency")]
    public required string SourceCurrency { get; init; }

    [JsonPropertyName("TargetCurrency")]
    public string? TargetCurrency { get; init; }

    [JsonPropertyName("UnitCurrency")]
    public string? UnitCurrency { get; init; }

    [JsonPropertyName("ExchangeRate")]
    public required decimal ExchangeRate { get; init; }

    [JsonPropertyName("ContractIdentification")]
    public string? ContractIdentification { get; init; }

    [JsonPropertyName("QuotationDate")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? QuotationDate { get; init; }

    [JsonPropertyName("InstructedAmount")]
    public InstructedAmount3? InstructedAmount { get; init; }
}
