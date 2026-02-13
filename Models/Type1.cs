using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public record Type1 : StringEnum<Type1>
{
    public static readonly Type1 PreAgreed = new("Pre-Agreed");

    public static readonly Type1 Emergency = new("Emergency");

    public static readonly Type1 Temporary = new("Temporary");

    private Type1(string value) : base(value)
    {
    }
}
