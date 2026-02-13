using System.Text.Json.Serialization;
using PnzApi.Core.Converters;

namespace PnzApi.Models;

public record TransactionModel
{
    [JsonPropertyName("AccountId")]
    public required string AccountId { get; init; }

    [JsonPropertyName("TransactionId")]
    public string? TransactionId { get; init; }

    [JsonPropertyName("TransactionReference")]
    public TransactionReference? TransactionReference { get; init; }

    [JsonPropertyName("StatementReference")]
    public IReadOnlyList<string>? StatementReference { get; init; }

    [JsonPropertyName("Amount")]
    public required Amount10 Amount { get; init; }

    [JsonPropertyName("CreditDebitIndicator")]
    public required CreditDebitIndicator1 CreditDebitIndicator { get; init; }

    [JsonPropertyName("Status")]
    public required Status1 Status { get; init; }

    [JsonPropertyName("BookingDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public required DateTimeOffset BookingDateTime { get; init; }

    [JsonPropertyName("ValueDateTime")]
    [JsonConverter(typeof(Iso8601DateTimeConverter))]
    public DateTimeOffset? ValueDateTime { get; init; }

    [JsonPropertyName("AddressLine")]
    public string? AddressLine { get; init; }

    [JsonPropertyName("BankTransactionCode")]
    public BankTransactionCode2? BankTransactionCode { get; init; }

    [JsonPropertyName("ProprietaryBankTransactionCode")]
    public ProprietaryBankTransactionCode2? ProprietaryBankTransactionCode { get; init; }

    [JsonPropertyName("CurrencyExchange")]
    public CurrencyExchange2? CurrencyExchange { get; init; }

    [JsonPropertyName("CreditorAgent")]
    public CreditorAgent3? CreditorAgent { get; init; }

    [JsonPropertyName("DebtorAgent")]
    public DebtorAgent2? DebtorAgent { get; init; }

    [JsonPropertyName("CardInstrument")]
    public CardInstrument2? CardInstrument { get; init; }

    [JsonPropertyName("TransactionInformation")]
    public string? TransactionInformation { get; init; }

    [JsonPropertyName("Balance")]
    public Balance2? Balance { get; init; }

    [JsonPropertyName("MerchantDetails")]
    public MerchantDetails2? MerchantDetails { get; init; }

    [JsonPropertyName("CreditorAccount")]
    public CreditorAccount5? CreditorAccount { get; init; }

    [JsonPropertyName("DebtorAccount")]
    public DebtorAccount2? DebtorAccount { get; init; }
}
