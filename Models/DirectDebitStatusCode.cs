using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<DirectDebitStatusCode>))]
public record DirectDebitStatusCode : StringEnum<DirectDebitStatusCode>
{
    public static readonly DirectDebitStatusCode Active = new("Active");

    public static readonly DirectDebitStatusCode Inactive = new("Inactive");

    private DirectDebitStatusCode(string value) : base(value)
    {
    }
}
