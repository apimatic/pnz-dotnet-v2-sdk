using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type5>))]
public record Type5 : StringEnum<Type5>
{
    public static readonly Type5 Annual = new("Annual");

    public static readonly Type5 BalanceTransfer = new("BalanceTransfer");

    public static readonly Type5 CashAdvance = new("CashAdvance");

    public static readonly Type5 CashTransaction = new("CashTransaction");

    public static readonly Type5 ForeignTransaction = new("ForeignTransaction");

    public static readonly Type5 Gambling = new("Gambling");

    public static readonly Type5 LatePayment = new("LatePayment");

    public static readonly Type5 MoneyTransfer = new("MoneyTransfer");

    public static readonly Type5 Monthly = new("Monthly");

    public static readonly Type5 Overlimit = new("Overlimit");

    public static readonly Type5 PostalOrder = new("PostalOrder");

    public static readonly Type5 PrizeEntry = new("PrizeEntry");

    public static readonly Type5 StatementCopy = new("StatementCopy");

    public static readonly Type5 Total = new("Total");

    private Type5(string value) : base(value)
    {
    }
}
