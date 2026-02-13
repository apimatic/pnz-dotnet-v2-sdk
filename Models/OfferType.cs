using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<OfferType>))]
public record OfferType : StringEnum<OfferType>
{
    public static readonly OfferType BalanceTransfer = new("BalanceTransfer");

    public static readonly OfferType LimitIncrease = new("LimitIncrease");

    public static readonly OfferType MoneyTransfer = new("MoneyTransfer");

    public static readonly OfferType Other = new("Other");

    public static readonly OfferType PromotionalRate = new("PromotionalRate");

    private OfferType(string value) : base(value)
    {
    }
}
