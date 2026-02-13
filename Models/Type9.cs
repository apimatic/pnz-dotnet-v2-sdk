using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type9>))]
public record Type9 : StringEnum<Type9>
{
    public static readonly Type9 AirMilesPoints = new("AirMilesPoints");

    public static readonly Type9 AirMilesPointsBalance = new("AirMilesPointsBalance");

    public static readonly Type9 Credits = new("Credits");

    public static readonly Type9 Debits = new("Debits");

    public static readonly Type9 HotelPoints = new("HotelPoints");

    public static readonly Type9 HotelPointsBalance = new("HotelPointsBalance");

    public static readonly Type9 RetailShoppingPoints = new("RetailShoppingPoints");

    public static readonly Type9 RetailShoppingPointsBalance = new("RetailShoppingPointsBalance");

    private Type9(string value) : base(value)
    {
    }
}
