using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type7>))]
public record Type7 : StringEnum<Type7>
{
    public static readonly Type7 BalanceTransferPromoEnd = new("BalanceTransferPromoEnd");

    public static readonly Type7 DirectDebitDue = new("DirectDebitDue");

    public static readonly Type7 LastPayment = new("LastPayment");

    public static readonly Type7 LastStatement = new("LastStatement");

    public static readonly Type7 NextStatement = new("NextStatement");

    public static readonly Type7 PaymentDue = new("PaymentDue");

    public static readonly Type7 PurchasePromoEnd = new("PurchasePromoEnd");

    public static readonly Type7 StatementAvailable = new("StatementAvailable");

    private Type7(string value) : base(value)
    {
    }
}
