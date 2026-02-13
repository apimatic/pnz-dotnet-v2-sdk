using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public record AccountType : StringEnum<AccountType>
{
    public static readonly AccountType Business = new("Business");

    public static readonly AccountType Personal = new("Personal");

    private AccountType(string value) : base(value)
    {
    }
}
