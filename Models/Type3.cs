using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type3>))]
public record Type3 : StringEnum<Type3>
{
    public static readonly Type3 AccountClosure = new("AccountClosure");

    public static readonly Type3 AccountOpening = new("AccountOpening");

    public static readonly Type3 Annual = new("Annual");

    public static readonly Type3 Interim = new("Interim");

    public static readonly Type3 RegularPeriodic = new("RegularPeriodic");

    private Type3(string value) : base(value)
    {
    }
}
