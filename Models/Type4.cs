using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type4>))]
public record Type4 : StringEnum<Type4>
{
    public static readonly Type4 Cashback = new("Cashback");

    public static readonly Type4 Insurance = new("Insurance");

    public static readonly Type4 TravelDiscount = new("TravelDiscount");

    public static readonly Type4 TravelInsurance = new("TravelInsurance");

    private Type4(string value) : base(value)
    {
    }
}
