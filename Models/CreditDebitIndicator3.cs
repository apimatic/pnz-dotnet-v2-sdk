using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<CreditDebitIndicator3>))]
public record CreditDebitIndicator3 : StringEnum<CreditDebitIndicator3>
{
    public static readonly CreditDebitIndicator3 Credit = new("Credit");

    public static readonly CreditDebitIndicator3 Debit = new("Debit");

    private CreditDebitIndicator3(string value) : base(value)
    {
    }
}
