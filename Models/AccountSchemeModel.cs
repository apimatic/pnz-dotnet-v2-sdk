using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<AccountSchemeModel>))]
public record AccountSchemeModel : StringEnum<AccountSchemeModel>
{
    public static readonly AccountSchemeModel BecselectronicCredit = new("BECSElectronicCredit");

    public static readonly AccountSchemeModel MaskedCardNumber = new("MaskedCardNumber");

    private AccountSchemeModel(string value) : base(value)
    {
    }
}
