using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type10>))]
public record Type10 : StringEnum<Type10>
{
    public static readonly Type10 ArrearsClosingBalance = new("ArrearsClosingBalance");

    public static readonly Type10 AvailableBalance = new("AvailableBalance");

    public static readonly Type10 AverageBalanceWhenInCredit = new("AverageBalanceWhenInCredit");

    public static readonly Type10 AverageBalanceWhenInDebit = new("AverageBalanceWhenInDebit");

    public static readonly Type10 AverageDailyBalance = new("AverageDailyBalance");

    public static readonly Type10 BalanceTransferClosingBalance = new("BalanceTransferClosingBalance");

    public static readonly Type10 CashClosingBalance = new("CashClosingBalance");

    public static readonly Type10 ClosingBalance = new("ClosingBalance");

    public static readonly Type10 CreditLimit = new("CreditLimit");

    public static readonly Type10 CurrentPayment = new("CurrentPayment");

    public static readonly Type10 DirectDebitPaymentDue = new("DirectDebitPaymentDue");

    public static readonly Type10 MinimumPaymentDue = new("MinimumPaymentDue");

    public static readonly Type10 PreviousClosingBalance = new("PreviousClosingBalance");

    public static readonly Type10 PreviousPayment = new("PreviousPayment");

    public static readonly Type10 PurchaseClosingBalance = new("PurchaseClosingBalance");

    public static readonly Type10 StartingBalance = new("StartingBalance");

    public static readonly Type10 TotalAdjustments = new("TotalAdjustments");

    public static readonly Type10 TotalCashAdvances = new("TotalCashAdvances");

    public static readonly Type10 TotalCharges = new("TotalCharges");

    public static readonly Type10 TotalCredits = new("TotalCredits");

    public static readonly Type10 TotalDebits = new("TotalDebits");

    public static readonly Type10 TotalPurchases = new("TotalPurchases");

    private Type10(string value) : base(value)
    {
    }
}
