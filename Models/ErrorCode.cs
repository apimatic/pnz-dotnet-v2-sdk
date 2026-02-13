using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<ErrorCode>))]
public record ErrorCode : StringEnum<ErrorCode>
{
    public static readonly ErrorCode FieldExpected = new("Field.Expected");

    public static readonly ErrorCode FieldInvalid = new("Field.Invalid");

    public static readonly ErrorCode FieldMissing = new("Field.Missing");

    public static readonly ErrorCode FieldUnexpected = new("Field.Unexpected");

    public static readonly ErrorCode HeaderInvalid = new("Header.Invalid");

    public static readonly ErrorCode HeaderMissing = new("Header.Missing");

    public static readonly ErrorCode QueryParamInvalid = new("QueryParam.Invalid");

    public static readonly ErrorCode Reauthenticate = new("Reauthenticate");

    public static readonly ErrorCode Reauthorise = new("Reauthorise");

    public static readonly ErrorCode ResourceConsentCreditorAccount = new("Resource.Consent.CreditorAccount");

    public static readonly ErrorCode ResourceConsentDebtorAccount = new("Resource.Consent.DebtorAccount");

    public static readonly ErrorCode ResourceConsentExceedDataPermissions = new("Resource.Consent.Exceed.DataPermissions");

    public static readonly ErrorCode ResourceConsentExceedDates = new("Resource.Consent.Exceed.Dates");

    public static readonly ErrorCode ResourceConsentExceedFrequency = new("Resource.Consent.Exceed.Frequency");

    public static readonly ErrorCode ResourceConsentExceedMaximumAmount = new("Resource.Consent.Exceed.MaximumAmount");

    public static readonly ErrorCode ResourceConsentExceedTotalAmount = new("Resource.Consent.Exceed.TotalAmount");

    public static readonly ErrorCode ResourceConsentExceedTotalCount = new("Resource.Consent.Exceed.TotalCount");

    public static readonly ErrorCode ResourceConsentExceedTransactionDates = new("Resource.Consent.Exceed.TransactionDates");

    public static readonly ErrorCode ResourceConsentInvalidStatus = new("Resource.Consent.InvalidStatus");

    public static readonly ErrorCode ResourceConsentMismatch = new("Resource.Consent.Mismatch");

    public static readonly ErrorCode ResourceInvalid = new("Resource.Invalid");

    public static readonly ErrorCode UnexpectedError = new("UnexpectedError");

    public static readonly ErrorCode UnsupportedAccountIdentifier = new("Unsupported.AccountIdentifier");

    public static readonly ErrorCode UnsupportedAccountSecondaryIdentifier = new("Unsupported.AccountSecondaryIdentifier");

    public static readonly ErrorCode UnsupportedCurrency = new("Unsupported.Currency");

    public static readonly ErrorCode UnsupportedScheme = new("Unsupported.Scheme");

    private ErrorCode(string value) : base(value)
    {
    }
}
