using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<ScheduledType>))]
public record ScheduledType : StringEnum<ScheduledType>
{
    public static readonly ScheduledType Arrival = new("Arrival");

    public static readonly ScheduledType Execution = new("Execution");

    private ScheduledType(string value) : base(value)
    {
    }
}
