using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Status1>))]
public record Status1 : StringEnum<Status1>
{
    public static readonly Status1 Booked = new("Booked");

    public static readonly Status1 Pending = new("Pending");

    private Status1(string value) : base(value)
    {
    }
}
