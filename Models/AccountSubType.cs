using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<AccountSubType>))]
public record AccountSubType : StringEnum<AccountSubType>
{
    public static readonly AccountSubType ChargeCard = new("ChargeCard");

    public static readonly AccountSubType CreditCard = new("CreditCard");

    public static readonly AccountSubType CurrentAccount = new("CurrentAccount");

    public static readonly AccountSubType Emoney = new("EMoney");

    public static readonly AccountSubType Loan = new("Loan");

    public static readonly AccountSubType Mortgage = new("Mortgage");

    public static readonly AccountSubType PrePaidCard = new("PrePaidCard");

    public static readonly AccountSubType Savings = new("Savings");

    private AccountSubType(string value) : base(value)
    {
    }
}
