using System.Text.Json.Serialization;
using PnzApi.Core.Enum;

namespace PnzApi.Models;

[JsonConverter(typeof(StringEnumConverter<AuthorisationType>))]
public record AuthorisationType : StringEnum<AuthorisationType>
{
    public static readonly AuthorisationType Contactless = new("Contactless");

    public static readonly AuthorisationType None = new("None");

    public static readonly AuthorisationType Pin = new("PIN");

    private AuthorisationType(string value) : base(value)
    {
    }
}
