using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<CardSchemeName>))]
public record CardSchemeName : StringEnum<CardSchemeName>
{
    public static readonly CardSchemeName AmericanExpress = new("AmericanExpress");

    public static readonly CardSchemeName Diners = new("Diners");

    public static readonly CardSchemeName Discover = new("Discover");

    public static readonly CardSchemeName MasterCard = new("MasterCard");

    public static readonly CardSchemeName Visa = new("VISA");

    private CardSchemeName(string value) : base(value)
    {
    }
}
