using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type8>))]
public record Type8 : StringEnum<Type8>
{
    public static readonly Type8 AnnualBalanceTransfer = new("AnnualBalanceTransfer");

    public static readonly Type8 AnnualBalanceTransferAfterPromo = new("AnnualBalanceTransferAfterPromo");

    public static readonly Type8 AnnualBalanceTransferPromo = new("AnnualBalanceTransferPromo");

    public static readonly Type8 AnnualCash = new("AnnualCash");

    public static readonly Type8 AnnualPurchase = new("AnnualPurchase");

    public static readonly Type8 AnnualPurchaseAfterPromo = new("AnnualPurchaseAfterPromo");

    public static readonly Type8 AnnualPurchasePromo = new("AnnualPurchasePromo");

    public static readonly Type8 MonthlyBalanceTransfer = new("MonthlyBalanceTransfer");

    public static readonly Type8 MonthlyCash = new("MonthlyCash");

    public static readonly Type8 MonthlyPurchase = new("MonthlyPurchase");

    private Type8(string value) : base(value)
    {
    }
}
