using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<SchemeName>))]
public record SchemeName : StringEnum<SchemeName>
{
    public static readonly SchemeName Bicfi = new("BICFI");

    private SchemeName(string value) : base(value)
    {
    }
}
