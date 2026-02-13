using System.Text.Json.Serialization;

namespace PnzApi.Models;

public record MerchantDetails2
{
    [JsonPropertyName("MerchantName")]
    public string? MerchantName { get; init; }

    [JsonPropertyName("MerchantCategoryCode")]
    public string? MerchantCategoryCode { get; init; }
}
