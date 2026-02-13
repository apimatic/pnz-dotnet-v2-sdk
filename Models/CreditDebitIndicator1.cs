using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<CreditDebitIndicator1>))]
public record CreditDebitIndicator1 : StringEnum<CreditDebitIndicator1>
{
    public static readonly CreditDebitIndicator1 Credit = new("Credit");

    public static readonly CreditDebitIndicator1 Debit = new("Debit");

    private CreditDebitIndicator1(string value) : base(value)
    {
    }
}
