using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type>))]
public record Type : StringEnum<Type>
{
    public static readonly Type ClosingAvailable = new("ClosingAvailable");

    public static readonly Type ClosingBooked = new("ClosingBooked");

    public static readonly Type Expected = new("Expected");

    public static readonly Type ForwardAvailable = new("ForwardAvailable");

    public static readonly Type Information = new("Information");

    public static readonly Type InterimAvailable = new("InterimAvailable");

    public static readonly Type InterimBooked = new("InterimBooked");

    public static readonly Type OpeningAvailable = new("OpeningAvailable");

    public static readonly Type OpeningBooked = new("OpeningBooked");

    public static readonly Type PreviouslyClosedBooked = new("PreviouslyClosedBooked");

    private Type(string value) : base(value)
    {
    }
}
