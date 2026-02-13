using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<AddressType>))]
public record AddressType : StringEnum<AddressType>
{
    public static readonly AddressType DeliveryTo = new("DeliveryTo");

    private AddressType(string value) : base(value)
    {
    }
}
