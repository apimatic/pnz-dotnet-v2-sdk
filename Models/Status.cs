using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<Status>))]
public record Status : StringEnum<Status>
{
    public static readonly Status Authorised = new("Authorised");

    public static readonly Status AwaitingAuthorisation = new("AwaitingAuthorisation");

    public static readonly Status Rejected = new("Rejected");

    public static readonly Status Revoked = new("Revoked");

    private Status(string value) : base(value)
    {
    }
}
