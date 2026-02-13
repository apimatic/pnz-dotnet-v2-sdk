using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Type6>))]
public record Type6 : StringEnum<Type6>
{
    public static readonly Type6 BalanceTransfer = new("BalanceTransfer");

    public static readonly Type6 Cash = new("Cash");

    public static readonly Type6 EstimatedNext = new("EstimatedNext");

    public static readonly Type6 Purchase = new("Purchase");

    public static readonly Type6 Total = new("Total");

    private Type6(string value) : base(value)
    {
    }
}
