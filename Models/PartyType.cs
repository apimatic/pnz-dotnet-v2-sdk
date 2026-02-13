using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<PartyType>))]
public record PartyType : StringEnum<PartyType>
{
    public static readonly PartyType Delegate = new("Delegate");

    public static readonly PartyType Joint = new("Joint");

    public static readonly PartyType Sole = new("Sole");

    private PartyType(string value) : base(value)
    {
    }
}
