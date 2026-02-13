using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<AddressType1>))]
public record AddressType1 : StringEnum<AddressType1>
{
    public static readonly AddressType1 Business = new("Business");

    public static readonly AddressType1 Correspondence = new("Correspondence");

    public static readonly AddressType1 DeliveryTo = new("DeliveryTo");

    public static readonly AddressType1 MailTo = new("MailTo");

    public static readonly AddressType1 Pobox = new("POBox");

    public static readonly AddressType1 Postal = new("Postal");

    public static readonly AddressType1 Residential = new("Residential");

    public static readonly AddressType1 Statement = new("Statement");

    private AddressType1(string value) : base(value)
    {
    }
}
