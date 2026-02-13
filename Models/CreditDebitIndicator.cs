using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<CreditDebitIndicator>))]
public record CreditDebitIndicator : StringEnum<CreditDebitIndicator>
{
    public static readonly CreditDebitIndicator Credit = new("Credit");

    public static readonly CreditDebitIndicator Debit = new("Debit");

    private CreditDebitIndicator(string value) : base(value)
    {
    }
}
