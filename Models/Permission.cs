using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Permission>))]
public record Permission : StringEnum<Permission>
{
    public static readonly Permission ReadAccountsBasic = new("ReadAccountsBasic");

    public static readonly Permission ReadAccountsDetail = new("ReadAccountsDetail");

    public static readonly Permission ReadBalances = new("ReadBalances");

    public static readonly Permission ReadBeneficiariesBasic = new("ReadBeneficiariesBasic");

    public static readonly Permission ReadBeneficiariesDetail = new("ReadBeneficiariesDetail");

    public static readonly Permission ReadDirectDebits = new("ReadDirectDebits");

    public static readonly Permission ReadOffers = new("ReadOffers");

    public static readonly Permission ReadParty = new("ReadParty");

    public static readonly Permission ReadPartyAuthUser = new("ReadPartyAuthUser");

    public static readonly Permission ReadScheduledPaymentsBasic = new("ReadScheduledPaymentsBasic");

    public static readonly Permission ReadScheduledPaymentsDetail = new("ReadScheduledPaymentsDetail");

    public static readonly Permission ReadStandingOrdersBasic = new("ReadStandingOrdersBasic");

    public static readonly Permission ReadStandingOrdersDetail = new("ReadStandingOrdersDetail");

    public static readonly Permission ReadStatementsBasic = new("ReadStatementsBasic");

    public static readonly Permission ReadStatementsDetail = new("ReadStatementsDetail");

    public static readonly Permission ReadTransactionsBasic = new("ReadTransactionsBasic");

    public static readonly Permission ReadTransactionsCredits = new("ReadTransactionsCredits");

    public static readonly Permission ReadTransactionsDebits = new("ReadTransactionsDebits");

    public static readonly Permission ReadTransactionsDetail = new("ReadTransactionsDetail");

    private Permission(string value) : base(value)
    {
    }
}
