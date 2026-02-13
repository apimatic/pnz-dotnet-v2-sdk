using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<StandingOrderStatusCode>))]
public record StandingOrderStatusCode : StringEnum<StandingOrderStatusCode>
{
    public static readonly StandingOrderStatusCode Active = new("Active");

    public static readonly StandingOrderStatusCode Inactive = new("Inactive");

    private StandingOrderStatusCode(string value) : base(value)
    {
    }
}
