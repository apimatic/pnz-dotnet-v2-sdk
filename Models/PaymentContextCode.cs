using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<PaymentContextCode>))]
public record PaymentContextCode : StringEnum<PaymentContextCode>
{
    public static readonly PaymentContextCode BillPayment = new("BillPayment");

    public static readonly PaymentContextCode EcommerceGoods = new("EcommerceGoods");

    public static readonly PaymentContextCode EcommerceServices = new("EcommerceServices");

    public static readonly PaymentContextCode Other = new("Other");

    public static readonly PaymentContextCode PersonToPerson = new("PersonToPerson");

    private PaymentContextCode(string value) : base(value)
    {
    }
}
